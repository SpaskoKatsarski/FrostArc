namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Post;

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

        public async Task<int> UnlikeAsync(string id, string userId)
        {
            Post post = await this.dbContext.Posts
                .FirstAsync(p => p.Id.ToString() == id);
            
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            this.dbContext.PostsReactions.Remove(pr);
            post.Likes--;
            await this.dbContext.SaveChangesAsync();

            return post.Likes;
        }

        public async Task<Tuple<int, int>> ChangeDislikeToLikeAsync(string id, string userId)
        {
            PostReaction pr = await this.dbContext.PostsReactions
                .FirstAsync(pr => pr.PostId.ToString() == id && pr.UserId.ToString() == userId);

            Post post = await this.dbContext.Posts
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

        public async Task<Comment> AddCommentAsync(string postId, string userId, string commentContent)
        {
            Post? post = await this.dbContext.Posts
                .FirstOrDefaultAsync(p => p.Id.ToString() == postId);

            if (post == null)
            {
                throw new ArgumentException("Post with the provided ID does not exist!");
            }

            Comment comment = new Comment()
            { 
                Content = commentContent,
                PostId = Guid.Parse(postId),
                UserId = Guid.Parse(userId)
            };

            post.Comments.Add(comment);

            await this.dbContext.SaveChangesAsync();

            return comment;
        }
    }
}
