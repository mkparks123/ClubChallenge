using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class MemberEventData
    {
        
        //need to add a primary key, once fixed, we need to add-migration etc
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int EventID { get; set; }

    }
}