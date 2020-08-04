using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitzen_LeninAguiar.Models
{
    public class SupplyViewModel
    {
        public int id { get; set; }

        public int kmsupply { get; set; }

        public int quantity { get; set; }

        public float value { get; set; }

        public DateTime datasupply { get; set; }

        public int userid { get; set; }

        public String fueltype { get; set; }

        public int vehicleid { get; set; }

        public String message { get; set; }

        public List<Vehicle> vehicles { get; set; }

        public String companyname { get; set; }

        public List<Supply> supplies { get; set; }

    }

}
