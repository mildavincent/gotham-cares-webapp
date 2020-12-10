using System;
using System.Collections.Generic;

namespace GothamCares.Data
{
    public class Outlet
    {
        /// <summary>
        /// Gets or sets the Id of an outlet
        /// </summary>
        public int Id { get; set; }

     
        public string Name { get; set; }

        
        public string StreetName { get; set; }

       
        public string Landmark { get; set; }

       
        public DateTime OpeningDate { get; set; }

      
        public List<FoodPacket> FoodPackets { get; set; }

       // public int ReqVolunteers { get; set; }
    }
}
