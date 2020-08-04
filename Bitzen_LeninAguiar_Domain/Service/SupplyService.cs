using Bitzen_LeninAguiar_Domain.Repository;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bitzen_LeninAguiar_Domain.Service
{
    public class SupplyService
    {
        private SupplyRepository supplyRepository;

        public SupplyService()
        {
            supplyRepository = new SupplyRepository();
        }

        public bool Create(Supply supply)
        {
            bool result = false;
            try {
                supplyRepository.saveUpdate(supply);
                result = true;
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        public List<Supply> FindByUserId(int userid)
        {
            List<Supply> supplies = new List<Supply>();
            try {
                supplies = supplyRepository.findAll().Where(w => w.userid == userid).ToList();
            }
            catch(Exception ex) { 
            }
            return supplies;
        }

    }

}
