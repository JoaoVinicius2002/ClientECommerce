using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientECommerce.Models
{
    public class Team
    {
        public Team()
        {

        }
        public Team(string name, string description, string licensePlateNumber)
        {
            Name = name;
            Description = description;
            LicensePlateNumber = licensePlateNumber;
        }
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
