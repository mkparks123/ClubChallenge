using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClubChallenge.Models
{
    public class DBEntities:DbContext  //DBEntities class inheriting from DBContext Class
    {                                  //Establised a connection to our DataBase

        public DBEntities()
        {

        }
        public DbSet<Event> Events { get; set; } //we can access all our events in database using the Events property
        public DbSet<Member> Members { get; set; } //we can access all our members in database using the Members property
        public DbSet<MemberEventData> Membereventdata { get; set; }//need to fix this model still

    }
}