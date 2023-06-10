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
    internal class NoteAdditionModelConfiguration: BaseModelConfiguration<NoteAddition>
    {
        public override void Configure(EntityTypeBuilder<NoteAddition> builder)
        {
            base.Configure(builder);

            builder.ToTable("NoteAddition", NoteKeeperContext.DEFAULT_SCHEMA);


            // iki ilişkilendirme yapıldı 

            builder.HasOne(i => i.Note)
                .WithMany(i => i.NoteAdditions)
                .HasForeignKey(i => i.NoteId);

            builder
                .HasOne(i => i.User)
                .WithMany(i => i.NoteAdditions)
                .HasForeignKey(i => i.UserId);
        }
    }
}
