namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;

    public class ModeratorService : IModeratorService
    {
        private FrostArcDbContext dbContext;

        public ModeratorService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task DemoteAsync(string userId, string communityId)
        {
            ModeratorCommunity? mc = await this.dbContext.ModeratorsCommunities
                .FindAsync(Guid.Parse(userId), Guid.Parse(communityId));

            if (mc == null)
            {
                throw new ArgumentException("Provided data is not valid!");
            }

            this.dbContext.ModeratorsCommunities.Remove(mc);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsModeratorAsync(string userId, string communityId)
        {
            return await this.dbContext.ModeratorsCommunities
                .AnyAsync(mc => mc.ModeratorId.ToString() == userId 
                && mc.CommunityId.ToString() == communityId);
        }

        public async Task PromoteAsync(string userId, string communityId)
        {
            ApplicationUser? user = await this.dbContext.Users
                .FindAsync(Guid.Parse(userId));

            if (user == null)
            {
                throw new ArgumentException("User wit the provided ID does not exist!");
            }

            Community? community = await this.dbContext.Communities
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id.ToString() == communityId);

            if (community == null)
            {
                throw new ArgumentException("Community wit the provided ID does not exist!");
            }

            ModeratorCommunity mc = new ModeratorCommunity()
            {
                ModeratorId = user.Id,
                CommunityId = community.Id
            };

            await this.dbContext.ModeratorsCommunities.AddAsync(mc);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
