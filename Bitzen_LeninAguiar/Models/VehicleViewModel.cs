using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitzen_LeninAguiar.Models
{
    public class VehicleViewModel
    {
        public int id { get; set; }
        public String brand { get; set; }
        public String model { get; set; }
        public int year { get; set; }
        public String plaque { get; set; }
        public String transporttype { get; set; }
        public String fueltype { get; set; }
        public int kilometers { get; set; }
        public int userid { get; set; }
        public String photopath { get; set; }

        public String message { get; set; }

        public List<Vehicle> vehicles { get; set; }
    }

}
