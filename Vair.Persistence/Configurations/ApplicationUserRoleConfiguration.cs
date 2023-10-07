using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vair.Domain.Entities;

namespace Vair.Persistence.Configurations
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });

            builder.HasOne(ur => ur.Role)
                    .WithMany(r => r.ApplicationUserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

            builder.HasOne(ur => ur.User)
                .WithMany(r => r.ApplicationUserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
        }
    }
}
