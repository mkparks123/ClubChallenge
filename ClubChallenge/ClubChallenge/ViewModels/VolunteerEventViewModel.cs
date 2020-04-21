using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubChallenge.Models;

namespace ClubChallenge.ViewModels
{
    public class VolunteerEventViewModel
    {
        public Member member { get; set; }
        public VolunteerEvents Vevents { get; set; }
    }
}