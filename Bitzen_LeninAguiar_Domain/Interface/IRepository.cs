using System;
using System.Collections.Generic;
using System.Text;

namespace Bitzen_LeninAguiar_Domain.Interface
{
    public interface IRepository<T>
    {
        public T saveUpdate(T entry);

        public bool delete(T entry);

        public List<T> findAll();

        public List<T> find(T entry);

        public List<T> find(int id);
    }

}
