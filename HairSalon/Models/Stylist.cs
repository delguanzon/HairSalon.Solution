using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; }
        public List<Client> Clients { get; set; }
    }
}