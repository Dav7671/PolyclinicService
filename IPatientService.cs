using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public interface IPatientService
    {
        void Update(Patient model);
        void Add(Patient model);
        List<Patient> GetAll();
        void Remove(Patient model);
        Patient Get(Guid id);
    }
}
