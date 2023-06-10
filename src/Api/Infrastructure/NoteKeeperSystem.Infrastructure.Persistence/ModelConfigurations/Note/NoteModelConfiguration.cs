using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeperSystem.Infrastructure.Persistence.Context;

namespace NoteKeeperSystem.Infrastructure.Persistence.ModelConfigurations.Note
{
    public class NoteModelConfiguration<T> : BaseModelConfiguration<NoteKeeperSystem.Api.Domain.Models.Note>
    {
        public override void Configure(EntityTypeBuilder<NoteKeeperSystem.Api.Domain.Models.Note> builder)
        {
            base.Configure(builder);

            builder.ToTable("Note", NoteKeeperContext.DEFAULT_SCHEMA);


            // bir kullanıcının birden fazla notu olabilir
            builder
                .HasOne(i => i.User)
                .WithMany(i => i.Notes)
                .HasForeignKey(i => i.UserId);

            
        }
    }
}
