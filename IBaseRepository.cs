using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public interface IBaseRepository<T>
    {
        void Add(T model);
        void Update(T model, int index);
        void Remove(T model);
        T Get(Guid id);
        List<T> GetAll();
        int IndexOf(T model);
    }
}
