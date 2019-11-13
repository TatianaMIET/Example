using TestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace TestProject.DAL
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            var users = new List<User>
            {
            new User {Surname="Carson", Name="Alexander", Login = "taty_sergeeva@mail.ru", Number = "+79999999999", Password = "1234" },
            new User {Surname="Sergeeva", Name="Tatiana", Login = "taty_sergeeva@mail.ru", Number = "+79999999999", Password = "124" }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();


            var timetables = new List<Timetable>
            {
            new Timetable { UserID = 1,  Discription = "Chemistry", TimeFrom = DateTime.Parse("2005-09-01"), TimeTo = DateTime.Parse("2005-09-01")},
            new Timetable { UserID = 1,  Discription = "Aaaaaa", TimeFrom = DateTime.Parse("2005-09-01"), TimeTo = DateTime.Parse("2005-09-01")},
            };

            timetables.ForEach(s => context.Timetables.Add(s));
            context.SaveChanges();


            var friends = new List<Friend>
            {
            new Friend {UserID = 1},
            new Friend {UserID = 2},
            };

            friends.ForEach(s => context.Friends.Add(s));
            context.SaveChanges();
        }
    }
}