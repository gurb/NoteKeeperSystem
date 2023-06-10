using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Api.Domain.Models
{
    public class Note: BaseModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<NoteAddition> NoteAdditions { get; set; }
        public virtual ICollection<NoteFavorite> NoteFavorites { get; set; }
    }
}
