using Bitzen_LeninAguiar_Domain.Interface;
using Bitzen_LeninAguiar_InfraStructure.Database;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bitzen_LeninAguiar_Domain.Repository
{
    public class SupplyRepository : ISupplyRepository
    {
        private Repository<Supply> repository;

        public SupplyRepository()
        {
            repository = new Repository<Supply>();
        }

        public bool delete(Supply entry)
        {
            return repository.delete(entry);
        }

        public List<Supply> find(Supply entry)
        {
            List<Supply> result = new List<Supply>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Supply.Where(w => w == entry).ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Supply> find(int id)
        {
            List<Supply> result = new List<Supply>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Supply.Where(w => w.id == id).ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Supply> findAll()
        {
            List<Supply> result = new List<Supply>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Supply.ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public Supply saveUpdate(Supply entry)
        {
            return repository.saveUpdate(entry);
        }

    }

}
