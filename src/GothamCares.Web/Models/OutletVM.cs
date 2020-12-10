using System;

namespace GothamCares.Web.Models
{
    public class OutletVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }

        public DateTime OpeningDate { get; set; }
       // public int ReqVolunteers { get; set; }
    }
}
