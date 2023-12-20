using FrostArc.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostArc.Data.Configurations
{
    public class PlatformEntityTypeConfiguration : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.HasData(this.SeedPlatforms());
        }

        private IEnumerable<Platform> SeedPlatforms()
        {
            var platforms = new List<Platform>
            {
                new Platform()
                {
                    Id = 1,
                    Name = "PC",
                    Description = "Games available for personal computers.",
                },
                new Platform()
                {
                    Id = 2,
                    Name = "PlayStation",
                    Description = "Games available for PlayStation consoles.",
                },
                new Platform()
                {
                    Id = 3,
                    Name = "Xbox",
                    Description = "Games available for Xbox consoles.",
                },
            };

            return platforms;
        }
    }
}
