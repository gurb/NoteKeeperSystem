using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeperSystem.Api.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
