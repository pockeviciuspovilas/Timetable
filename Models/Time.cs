using System;
using System.Collections.Generic;

#nullable disable

namespace TimetableProject.Models
{
    public partial class Time
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime InsertTime { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
