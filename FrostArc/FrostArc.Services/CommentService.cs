namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Comment;

    public class CommentService : ICommentService
    {
        private FrostArcDbContext dbContext;

        public CommentService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Tuple<string, string, bool>> AddCommentAsync(CommentInputViewModel inputModel)
        {
            Post? post = await this.dbContext.Posts
                .Include(p => p.Comments)
                .Include(p => p.Community)
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == inputModel.PostId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            Comment comment = new Comment()
            {
                Content = inputModel.Content,
                PostId = Guid.Parse(inputModel.PostId),
                UserId = Guid.Parse(inputModel.UserId)
            };

            await this.dbContext.Comments.AddAsync(comment);
            await this.dbContext.SaveChangesAsync();

            ApplicationUser user = await this.dbContext.Users
                .FindAsync(Guid.Parse(inputModel.UserId));

            string userDisplayName = user!.DisplayName;
            bool isUserOwner = post.Community.OwnerId.ToString() == user.Id.ToString();

            Tuple<string, string, bool> triple = new Tuple<string, string, bool>(comment.Content, userDisplayName, isUserOwner);

            return triple;
        }

        public async Task<bool> IsUserCreatorOfCommentAsync(string userId, string commentId)
        {
            Comment? comment = await this.dbContext.Comments
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == commentId);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            return comment.UserId.ToString() == userId;
        }

        public async Task<CommentEditViewModel> GetForEditAsync(string id, string userId, bool isUserOwnerOrMod)
        {
            Comment? comment = await this.dbContext.Comments
                .Include(c => c.User)
                .Include(c => c.Post)
                .ThenInclude(p => p.User)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == id);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            return new CommentEditViewModel()
            {
                Id = comment.Id.ToString(),
                User = comment.User.DisplayName,
                Content = comment.Content,
                PostTitle = comment.Post.Title,
                PostOwner = comment.Post.User.DisplayName,
                HasAccess = isUserOwnerOrMod || await this.IsUserCreatorOfCommentAsync(userId, id)
            };
        }

        public async Task EditAsync(CommentEditViewModel model)
        {
            Comment? comment = await this.dbContext.Comments
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == model.Id);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            comment.Content = model.Content;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<string> GetCommunityIdByCommentAsync(string commentId)
        {
            Comment? comment = await this.dbContext.Comments
                .Include(c => c.Post)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == commentId);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            return comment.Post.CommunityId.ToString();
        }

        public async Task<CommentDeleteViewModel> GetForDeleteAsync(string id, string userId, bool isUserOwnerOrMod)
        {
            Comment? comment = await this.dbContext.Comments
                .Include(c => c.User)
                .Include(c => c.Post)
                .ThenInclude(p => p.User)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == id);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            return new CommentDeleteViewModel()
            {
                Id = comment.Id.ToString(),
                Content = comment.Content,
                PostTitle = comment.Post.Title,
                PostOwner = comment.Post.User.DisplayName,
                HasAccess = isUserOwnerOrMod || await this.IsUserCreatorOfCommentAsync(userId, id)
            };
        }

        public async Task RemoveAsync(CommentDeleteViewModel model)
        {
            Comment? comment = await this.dbContext.Comments
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == model.Id);

            if (comment == null)
            {
                throw new ArgumentException("Comment with the provided ID does not exist!");
            }

            comment.IsDeleted = true;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
