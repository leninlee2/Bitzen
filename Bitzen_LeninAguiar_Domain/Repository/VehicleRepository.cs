using Bitzen_LeninAguiar_Domain.Interface;
using Bitzen_LeninAguiar_InfraStructure.Database;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bitzen_LeninAguiar_Domain.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private Repository<Vehicle> repository;

        public VehicleRepository()
        {
            repository = new Repository<Vehicle>();
        }

        public bool delete(Vehicle entry)
        {
            return repository.delete(entry);
        }

        public List<Vehicle> find(Vehicle entry)
        {
            List<Vehicle> result = new List<Vehicle>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Vehicle.Where(w => w == entry).ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Vehicle> find(int id)
        {
            List<Vehicle> result = new List<Vehicle>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Vehicle.Where(w => w.id == id).ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Vehicle> findAll()
        {
            List<Vehicle> result = new List<Vehicle>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Vehicle.ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public Vehicle saveUpdate(Vehicle entry)
        {
            return repository.saveUpdate(entry);
        }

    }

}
