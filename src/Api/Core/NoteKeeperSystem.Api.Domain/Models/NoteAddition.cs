using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Api.Domain.Models
{
    public class NoteAddition: BaseModel
    {
        public string? Content { get; set; }
        public Guid UserId { get; set; }
        public Guid NoteId { get; set; }

        public virtual Note Note { get; set; }
        public virtual User User { get; set; }
    }
}
