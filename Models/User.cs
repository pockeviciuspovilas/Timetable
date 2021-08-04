using System;
using System.Collections.Generic;

#nullable disable

namespace TimetableProject.Models
{
    public partial class User
    {
        public User()
        {
            Times = new HashSet<Time>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserTitleId { get; set; }

        public virtual UserTitle UserTitle { get; set; }
        public virtual ICollection<Time> Times { get; set; }
    }
}
