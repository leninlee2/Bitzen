using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_Domain.Interface
{
    public interface ISupplyService
    {
        bool Create(Supply supply);
        List<Supply> FindByUserId(int userid);

        List<Supply> SearchLitersMonth(int userid);
    }

}
