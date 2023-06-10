using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeperSystem.Api.Domain.Models;
using NoteKeeperSystem.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Infrastructure.Persistence.ModelConfigurations.Note
{
    public class NoteFavoriteModelConfiguration: BaseModelConfiguration<NoteFavorite>
    {
        public override void Configure(EntityTypeBuilder<NoteFavorite> builder)
        {
            base.Configure(builder);

            builder.ToTable("NoteFavorite", NoteKeeperContext.DEFAULT_SCHEMA);


            // iki ilişkilendirme yapıldı 

            builder.HasOne(i => i.Note)
                .WithMany(i => i.NoteFavorites)
                .HasForeignKey(i => i.NoteId);

            builder
                .HasOne(i => i.User)
                .WithMany(i => i.NoteFavorites)
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
