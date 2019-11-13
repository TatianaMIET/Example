using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Timetable
    {
        public int TimetableID { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public string Discription { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        
        
    }
}