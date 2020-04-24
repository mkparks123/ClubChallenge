using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubChallenge.Models;

namespace ClubChallenge.ViewModels
{
    public class MemberReports
    {
        public List<Member> Members { get; set; }
        public List<Event> Events { get; set; }
        public List<MemberClubHours> Memberclubhours { get; set; }
        public List<VolunteerEvents> Volunteerevents { get; set; }
    }
}