using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubChallenge.Models;

namespace ClubChallenge.ViewModels
{
    public class MemberReports
    {
        public Member Members { get; set; }
        public Event Events { get; set; }
        public MemberClubHours Memberclubhours { get; set; }
        public VolunteerEvents Volunteerevents { get; set; }
    }
}