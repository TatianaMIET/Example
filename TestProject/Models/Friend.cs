using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Friend
    {
        public int FriendID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }


    }
}