using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_Domain.Interface
{
    public interface IVehicleService
    {
        bool Create(Vehicle vehicle);
        List<Vehicle> FindByUser(int userid);
    }

}
