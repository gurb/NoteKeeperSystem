using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Api.Domain.Models
{
    public class User: BaseModel
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<NoteAddition> NoteAdditions { get; set; }
        public virtual ICollection<NoteFavorite> NoteFavorites { get; set; }
    }
}
