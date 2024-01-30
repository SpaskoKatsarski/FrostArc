namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.User;
    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Web.ViewModels.Community;
    using FrostArc.Web.ViewModels.Comment;

    public class UserService : IUserService
    {
        private FrostArcDbContext dbContext;

        public UserService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetDisplayNameAsync(string userId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            return user.DisplayName;
        }

        public async Task<UserDetailsViewModel> GetInfoAsync(string userId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .Include(u => u.Communities)
                .Include(u => u.Posts)
                .ThenInclude(p => p.Community)
                .Include(u => u.Posts)
                .ThenInclude(p => p.Comments)
                .ThenInclude(c => c.User)
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            Dictionary<string, List<PostAllViewModel>> postsByCommunity = this.GetPostsForCommunityAsync(user.Posts.Where(p => !p.IsDeleted));

            return new UserDetailsViewModel()
            {
                Id = user.Id.ToString(),
                DisplayName = user.DisplayName,
                ProfilePicture = user.ProfilePicture!,
                PostsByCommunity = postsByCommunity,
                Communities = user.Communities
                    .Where(c => !c.IsDeleted)
                    .Select(c => new CommunityAllViewModel()
                    {
                        Id = c.Id.ToString(),
                        Name = c.Name,
                        ImageUrl = c.ImageUrl
                    })
            };
        }

        private Dictionary<string, List<PostAllViewModel>> GetPostsForCommunityAsync(IEnumerable<Post> posts)
        {
            Dictionary<string, List<PostAllViewModel>> postsByCommunity = new Dictionary<string, List<PostAllViewModel>>();

            foreach (var post in posts)
            {
                if (!postsByCommunity.ContainsKey(post.Community.Name))
                {
                    postsByCommunity.Add(post.Community.Name, new List<PostAllViewModel>());
                }

                postsByCommunity[post.Community.Name].Add(new PostAllViewModel()
                {
                    Id = post.Id.ToString(),
                    Title = post.Title,
                    Content = post.Content,
                    ImageUrl = post.ImageUrl,
                    Likes = post.Likes,
                    Dislikes = post.Dislikes,
                    Comments = post.Comments
                                .Where(c => !c.IsDeleted)
                                .Select(c => new CommentPostViewModel()
                                {
                                    Id = c.Id.ToString(),
                                    UserId = c.UserId.ToString(),
                                    User = c.User.DisplayName,
                                    Content = c.Content
                                }),
                    Community = post.Community.Name
                });
            }

            return postsByCommunity;
        }

        public async Task<string> GetUserImageUrlAsync(string userId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            return user.ProfilePicture;
        }

        public async Task UpdateAvatarAsync(string userId, string imageUrl)
        {
            ApplicationUser? user = await this.dbContext.Users
               .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            user.ProfilePicture = imageUrl;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
