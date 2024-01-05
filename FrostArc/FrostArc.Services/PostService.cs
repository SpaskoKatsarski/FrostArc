namespace FrostArc.Services
{
    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Post;
    using Microsoft.EntityFrameworkCore;

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

            post.Dislikes++;
            await this.dbContext.SaveChangesAsync();

            return post.Dislikes;
        }
    }
}
