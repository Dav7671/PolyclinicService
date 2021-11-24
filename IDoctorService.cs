using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public interface IDoctorService
    {
        void Add(Doctor model);
        Doctor Get(Guid id);
        List<Doctor> GetAll();
        void Remove(Doctor model);
        void Update(Doctor model);
    }
}
