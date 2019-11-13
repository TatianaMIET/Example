using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class User
    {

        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }

    }
}
