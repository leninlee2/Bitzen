using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_InfraStructure.Entity
{
    public class Supply
    {
        public int id { get; set; }

        public int kmsupply { get; set; }

        public int quantity { get;set;} 
        
        public float value { get; set; }  
        
        public DateTime datasupply { get; set; } 
        
        public int userid { get; set; } 

        public String fueltype { get; set; } 
        
        public int vehicleid { get; set; }

        public String companyname { get; set; }

    }

}
