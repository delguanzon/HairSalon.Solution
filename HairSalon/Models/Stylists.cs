using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylists
    {
        public int StylistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }
        public string DateCreated { get; set; }
        public List<Clients> Clients { get; set; }
    }
}