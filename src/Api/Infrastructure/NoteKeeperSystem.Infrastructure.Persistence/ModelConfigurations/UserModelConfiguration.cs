using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeperSystem.Api.Domain.Models;
using NoteKeeperSystem.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Infrastructure.Persistence.ModelConfigurations
{

    public abstract class UserModelConfiguration<T> : BaseModelConfiguration<User> 
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.ToTable("User", NoteKeeperContext.DEFAULT_SCHEMA);
        }
    }

}
