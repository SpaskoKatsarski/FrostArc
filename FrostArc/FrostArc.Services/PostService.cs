namespace FrostArc.Services
{
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
    }
}
