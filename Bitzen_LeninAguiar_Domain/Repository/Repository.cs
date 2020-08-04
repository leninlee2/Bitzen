using Bitzen_LeninAguiar_InfraStructure.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_Domain.Repository
{
    public class Repository<T>
    {
        public bool delete(T entry)
        {
            bool result = true;
            try
            {
                using (var context = new DBBitzenContext())
                {
                    context.Remove(entry);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public T saveUpdate(T entry)
        {
            try
            {
                using (var context = new DBBitzenContext())
                {
                    context.Add(entry);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //generate log
            }
            return entry;
        }

    }

}
