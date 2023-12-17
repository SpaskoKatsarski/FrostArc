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
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            return new UserDetailsViewModel()
            {
                Id = user.Id.ToString(),
                DisplayName = user.DisplayName,
                ProfilePicture = user.ProfilePicture!,
                Posts = user.Posts
                .Select(p => new PostAllViewModel()
                {
                    Id = p.Id.ToString(),
                    Title = p.Title,
                    Content = p.Content,
                    ImageUrl = p.ImageUrl,
                    Likes = p.Likes,
                    Dislikes = p.Dislikes,
                    Comments = p.Comments
                        .Select(c => new CommentPostViewModel()
                        {
                            UserId = c.UserId.ToString(),
                            Content = c.Content
                        }),
                    Community = p.Community.Name
                }),
                Communitites = user.Communities.Select(c => new CommunityAllViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                })
            };
        }
    }
}
