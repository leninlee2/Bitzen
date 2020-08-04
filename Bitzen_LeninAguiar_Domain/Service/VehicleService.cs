using Bitzen_LeninAguiar_Domain.Repository;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bitzen_LeninAguiar_Domain.Service
{
    public class VehicleService
    {
        private VehicleRepository vehicleRepository;
        public VehicleService()
        {
            vehicleRepository = new VehicleRepository(); 
        }

        public bool Create(Vehicle vehicle)
        {
            bool result = false;
            try {
                vehicle = vehicleRepository.saveUpdate(vehicle);
                if (vehicle.id > 0)
                    result = true;
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        public List<Vehicle> FindByUser(int userid)
        {
            List<Vehicle> result = new List<Vehicle>(); 
            try {
                result = vehicleRepository.findAll().Where(w => w.userid == userid).ToList();
                
            }
            catch(Exception ex)
            {

            }
            return result;
        }


    }

}
