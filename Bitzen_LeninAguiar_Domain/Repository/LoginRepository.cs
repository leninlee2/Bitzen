using Bitzen_LeninAguiar_Domain.Interface;
using Bitzen_LeninAguiar_InfraStructure.Database;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bitzen_LeninAguiar_Domain.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private Repository<Login> repository;

        public LoginRepository()
        {
            repository = new Repository<Login>();
        }

        public bool delete(Login entry)
        {
            return repository.delete(entry);
        }

        public List<Login> find(Login entry)
        {
            List<Login> result = new List<Login>();
            try { 
                using(var context = new DBBitzenContext())
                {
                    result = context.Login.Where(w => w.email == entry.email 
                    && w.password == entry.password
                    ).ToList();
                }
            }
            catch(Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Login> find(int id)
        {
            List<Login> result = new List<Login>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Login.Where(w => w.id == id).ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public List<Login> findAll()
        {
            List<Login> result = new List<Login>();
            try
            {
                using (var context = new DBBitzenContext())
                {
                    result = context.Login.ToList();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return result;
        }

        public Login saveUpdate(Login entry)
        {
            return repository.saveUpdate(entry);
        }

    }

}
