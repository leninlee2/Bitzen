using Bitzen_LeninAguiar_Domain.Repository;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bitzen_LeninAguiar_Domain.Interface;

namespace Bitzen_LeninAguiar_Domain.Service
{
    public class SupplyService : ISupplyService
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

        public List<Supply> SearchLitersMonth(int userid)
        {
            List<Supply> supplies = new List<Supply>();
            try
            {
                supplies = supplyRepository.findAll().Where(w => w.userid == userid).ToList();
                var partial = supplies.Select(s => new { month = s.datasupply.Month, quantity = s.quantity }).
                    GroupBy(g => g.month).Select(s2 => new { value = s2.Sum(s3 => s3.quantity), month = s2.Key }).ToList();


                supplies = partial.Select(s => new Supply() { value = s.value, datasupply = new DateTime(1, s.month, DateTime.Now.Year) }).ToList();
            }
            catch (Exception ex)
            {
            }
            return supplies;
        }

    }

}
