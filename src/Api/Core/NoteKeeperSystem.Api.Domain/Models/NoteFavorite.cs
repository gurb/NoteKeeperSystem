using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Api.Domain.Models
{
    public class NoteFavorite: BaseModel
    {
        public Guid NoteId { get; set; }
        public Guid UserId { get; set; }

        public virtual Note Note { get; set; }
        public virtual User User { get; set; }
    }
}
