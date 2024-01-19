namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Community;
    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Web.ViewModels.Comment;
    using FrostArc.Web.ViewModels.User;

    public class CommunityService : ICommunityService
    {
        private FrostArcDbContext dbContext;

        public CommunityService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddUserToCommunityAsync(string communityId, string userId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            ApplicationUser? user = await this.dbContext.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            bool isAlreadyMember = await this.IsUserMemberAsync(communityId, userId);

            if (isAlreadyMember)
            {
                throw new ArgumentException("User is already member of this community!");
            }

            user.Communities.Add(community);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<Community> CreateAsync(CommunityFormViewModel model, string ownerId)
        {
            Community community = new Community()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                OwnerId = Guid.Parse(ownerId)
            };

            await this.dbContext.Communities.AddAsync(community);
            await this.dbContext.SaveChangesAsync();

            await this.AddUserToCommunityAsync(community.Id.ToString(), ownerId);

            return community;
        }

        public async Task DeleteCommunityAsync(string communityId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            this.dbContext.Remove(community);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<Community> FindAsync(string communityId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return community;
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetAllAsync()
        {
            return await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .OrderByDescending(c => c.Users.Count)
                .Select(c => new CommunityAllViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetCommunitiesForUserAsync(string userId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            return user.Communities
                .Select(c => new CommunityAllViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                });
        }

        public async Task<CommunityFeedViewModel> GetForFeedAsync(string id)
        {
            Community? community = await this.dbContext.Communities
                .Include(c => c.Posts)
                .ThenInclude(p => p.Comments)
                .Include(c => c.Users)
                .Include(c => c.Owner)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == id);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return new CommunityFeedViewModel()
            {
                Id = community.Id.ToString(),
                Name = community.Name,
                Description = community.Description,
                ImageUrl = community.ImageUrl,
                MembersCount = await this.GetMembersCountAsync(id),
                Posts = community.Posts
                    .Where(p => !p.IsDeleted)
                    .Select(p => new PostAllViewModel()
                    {
                        Id = p.Id.ToString(),
                        Title = p.Title,
                        Content = p.Content,
                        ImageUrl = p.ImageUrl,
                        Likes = p.Likes,
                        Dislikes = p.Dislikes,
                        UserId = p.UserId.ToString(),
                        Comments = p.Comments
                            .Select(c => new CommentPostViewModel()
                            {
                                UserId = c.UserId.ToString(),
                                Content = c.Content
                            })
                    }),
                Users = community.Users
                    .Select(u => new UserAllViewModel()
                    {
                        Id = u.Id.ToString(),
                        DisplayName = u.DisplayName
                    }).ToList(),
                OwnerId = community.OwnerId.ToString(),
                OwnerName = community.Owner.DisplayName
            };
        }

        public async Task<CommunityDetailsViewModel> GetForDetailsAsync(string id)
        {
            Community? community = await this.dbContext.Communities
                .Include(c => c.Posts)
                .ThenInclude(p => p.Comments)
                .Include(c => c.Users)
                .Include(c => c.Owner)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == id);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return new CommunityDetailsViewModel()
            {
                Id = community.Id.ToString(),
                Name = community.Name,
                Description = community.Description,
                ImageUrl = community.ImageUrl,
                MembersCount = await this.GetMembersCountAsync(id),
                OwnerId = community.OwnerId.ToString(),
                OwnerName = community.Owner.DisplayName
            };
        }

        public async Task<int> GetMembersCountAsync(string communityId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return community.Users.Count;
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetTop3Async()
        {
            IEnumerable<CommunityAllViewModel> communitites = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .OrderByDescending(c => c.Users.Count)
                .Select(c => new CommunityAllViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                }).ToListAsync();

            if (communitites.Count() < 3)
            {
                throw new InvalidOperationException("There are not enough Communities to be presented!");
            }

            return communitites;
        }

        public async Task<bool> IsUserMemberAsync(string communityId, string userId)
        {
            Community? community = await this.dbContext.Communities
                .Include(c => c.Users)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return community.Users.Any(u => u.Id.ToString() == userId);
        }

        public async Task<bool> IsUserOwnerAsync(string communityId, string userId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return community!.OwnerId.ToString() == userId;
        }

        public async Task<IEnumerable<CommunityAllViewModel>> SearchAsync(string queryStr)
        {
            return await this.dbContext.Communities
                .Where(c => c.Name.StartsWith(queryStr))
                .Select(c => new CommunityAllViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                }).ToListAsync();
        }

        public async Task UpdateCommunityAsync(CommunityFormViewModel updateModel)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == updateModel.Id);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            community.Name = updateModel.Name;
            community.Description = updateModel.Description;
            community.ImageUrl = updateModel.ImageUrl;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<CommunityUsersViewModel> GetCommunityUsersAsync(string communityId)
        {
            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return new CommunityUsersViewModel()
            {
                Id = community.Id.ToString(),
                Name = community.Name,
                Users = community.Users
                        .Select(u => new UserAllViewModel()
                        {
                            Id = u.Id.ToString(),
                            DisplayName = u.DisplayName,
                            ProfilePictureUrl = u.ProfilePicture
                        }).ToList()
            };
        }

        public async Task RemoveUserFromCommunityAsync(string communityId, string userId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .FindAsync(Guid.Parse(userId));

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            community.Users.Remove(user);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
