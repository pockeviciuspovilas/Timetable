using System;
using System.Collections.Generic;

#nullable disable

namespace TimetableProject.Models
{
    public partial class UserTitle
    {
        public UserTitle()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
