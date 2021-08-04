using System;
using System.Collections.Generic;

#nullable disable

namespace TimetableProject.Models
{
    public partial class Status
    {
        public Status()
        {
            Times = new HashSet<Time>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Time> Times { get; set; }
    }
}
