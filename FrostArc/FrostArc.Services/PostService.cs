namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Web.ViewModels.Comment;

    public class PostService : IPostService
    {
        private FrostArcDbContext dbContext;

        public PostService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Post> CreateAsync(PostFormViewModel model)
        {
            Post post = new Post()
            {
                Title = model.Title,
                Content = model.Content,
                ImageUrl = model.ImageUrl,
                UserId = Guid.Parse(model.UserId),
                CommunityId = Guid.Parse(model.CommunityId),
            };

            dbContext.Posts.Add(post);
            await dbContext.SaveChangesAsync();

            return post;
        }

        public Task<IEnumerable<PostAllViewModel>> GetAllForUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> LikeAsync(string id, string userId)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == id);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            post.PostReactions.Add(new PostReaction()
            {
                UserId = Guid.Parse(userId),
                PostId = Guid.Parse(id),
                Like = true
            });

            post.Likes++;
            await this.dbContext.SaveChangesAsync();

            return post.Likes;
        }

        public async Task<int> DislikeAsync(string id, string userId)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == id);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            post.PostReactions.Add(new PostReaction()
            {
                UserId = Guid.Parse(userId),
                PostId = Guid.Parse(id),
                Dislike = true
            });

            post.Dislikes++;
            await this.dbContext.SaveChangesAsync();

            return post.Dislikes;
        }

        public async Task<bool> HasUserInteractedAsync(string id, string userId)
        {
            return await this.dbContext.PostsReactions
                .AnyAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);
        }

        public async Task<Tuple<int, int>> UnlikeAsync(string id, string userId)
        {
            Post post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstAsync(p => p.Id.ToString() == id);

            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            post.Likes--;
            this.dbContext.PostsReactions.Remove(pr);
            await this.dbContext.SaveChangesAsync();

            Tuple<int, int> tuple = new Tuple<int, int>(post.Likes, post.Dislikes);

            return tuple;
        }

        public async Task<Tuple<int, int>> ChangeDislikeToLikeAsync(string id, string userId)
        {
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            Post post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstAsync(p => p.Id.ToString() == id);

            pr.Dislike = false;
            pr.Like = true;

            post.Likes++;
            post.Dislikes--;

            await this.dbContext.SaveChangesAsync();

            Tuple<int, int> tuple = new Tuple<int, int>(post.Likes, post.Dislikes);

            return tuple;
        }

        public async Task<bool> HasLikedAsync(string id, string userId)
        {
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            return pr.Like;
        }

        public async Task<bool> HasDislikedAsync(string id, string userId)
        {
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            return pr.Dislike;
        }

        public async Task<Tuple<int, int>> UndislikeAsync(string id, string userId)
        {
            Post post = await this.dbContext.Posts
                 .Where(p => !p.IsDeleted)
                 .FirstAsync(p => p.Id.ToString() == id);

            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            post.Dislikes--;
            this.dbContext.PostsReactions.Remove(pr);
            await this.dbContext.SaveChangesAsync();

            Tuple<int, int> tuple = new Tuple<int, int>(post.Likes, post.Dislikes);

            return tuple;
        }

        public async Task<Tuple<int, int>> ChangeLikeToDislikeAsync(string id, string userId)
        {
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            Post post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstAsync(p => p.Id.ToString() == id);

            pr.Like = false;
            pr.Dislike = true;

            post.Likes--;
            post.Dislikes++;

            await this.dbContext.SaveChangesAsync();

            Tuple<int, int> tuple = new Tuple<int, int>(post.Likes, post.Dislikes);

            return tuple;
        }

        public async Task<Comment> AddCommentAsync(CommentInputViewModel inputModel)
        {
            Post? post = await this.dbContext.Posts
                .Include(p => p.Comments)
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

            await this.dbContext.SaveChangesAsync();

            return comment;
        }

        public async Task EditAsync(PostFormViewModel model)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == model.PostId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            post.Title = model.Title;
            post.Content = model.Content;
            post.ImageUrl = model.ImageUrl;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostFormViewModel> GetForEditAsync(string postId)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == postId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            return new PostFormViewModel()
            {
                Title = post.Title,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
                UserId = post.UserId.ToString(),
                CommunityId = post.CommunityId.ToString()
            };
        }

        public async Task<bool> IsUserCreatorAsync(string postId, string userId)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == postId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            return post.UserId.ToString() == userId;
        }

        public async Task<PostDeleteViewModel> GetForDeleteAsync(string postId)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == postId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            return new PostDeleteViewModel()
            {
                Id = post.Id.ToString(),
                Title = post.Title,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
                CommunityId = post.CommunityId.ToString(),
                UserId = post.UserId.ToString()
            };
        }

        public async Task DeleteAsync(PostDeleteViewModel model)
        {
            Post? post = await this.dbContext.Posts
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id.ToString() == model.Id);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            post.IsDeleted = true;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
