namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Community;

    public class CommunityService : ICommunityService
    {
        private FrostArcDbContext context;

        public CommunityService(FrostArcDbContext context)
        {
            this.context = context;
        }

        public async Task AddUserToCommunityAsync(string communityId, string userId)
        {
            Community? community = await this.context.Communities
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            ApplicationUser? user = await this.context.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                throw new ArgumentException("User with the provided ID does not exist!");
            }

            user.Communities.Add(community);
            await this.context.SaveChangesAsync();
        }

        public async Task CreateAsync(CommunityFormViewModel model)
        {
            Community community = new Community()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl
            };

            await this.context.Communities.AddAsync(community);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCommunityAsync(string communityId)
        {
            Community? community = await this.context.Communities
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            this.context.Remove(community);
            await this.context.SaveChangesAsync();
        }

        public async Task<CommunityAllViewModel> FindAsync(string communityId)
        {
            Community? community = await this.context.Communities
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return new CommunityAllViewModel()
            {
                Id = community.Id.ToString(),
                Name = community.Name,
                ImageUrl = community.ImageUrl
            };
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetAllAsync()
        {
            return await this.context.Communities
                .Select(c => new CommunityAllViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                }).ToListAsync();
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetCommunitiesForUserAsync(string userId)
        {
            ApplicationUser? user = await this.context.Users
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

        public async Task<int> GetMembersCountAsync(string communityId)
        {
            Community? community = await this.context.Communities
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            return community.Users.Count;
        }

        public async Task<IEnumerable<CommunityAllViewModel>> GetTop3Async()
        {
            IEnumerable<CommunityAllViewModel> communitites = await this.context.Communities
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

        public async Task<IEnumerable<CommunityAllViewModel>> SearchAsync(string queryStr)
        {
            return await this.context.Communities
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
            Community? community = await this.context.Communities
                .FirstOrDefaultAsync(c => c.Id.ToString() == updateModel.Id);

            if (community == null)
            {
                throw new ArgumentException("Community with the provided ID does not exist!");
            }

            community.Name = updateModel.Name;
            community.Description = updateModel.Description;
            community.ImageUrl = updateModel.ImageUrl;
        }
    }
}
