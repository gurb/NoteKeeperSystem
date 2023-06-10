using Microsoft.EntityFrameworkCore;
using NoteKeeperSystem.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Infrastructure.Persistence.Context
{
    public class NoteKeeperContext: DbContext
    {

        public const string DEFAULT_SCHEMA = "dbo";

        public NoteKeeperContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; } 
        public DbSet<NoteAddition> NoteAdditions { get; set; }
        public DbSet<NoteFavorite> NoteFavorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            OnBeforeSaveChanges();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaveChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaveChanges();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSaveChanges();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void OnBeforeSaveChanges()
        {
            var newEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added)
                                                     .Select(x => (BaseModel)x.Entity);

            HandleNewEntities(newEntities);
        }

        private void HandleNewEntities(IEnumerable<BaseModel> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreateDate = DateTime.Now;
                entity.IsActive = true;
                entity.Guid = Guid.NewGuid();
            }
        }
    }
}
