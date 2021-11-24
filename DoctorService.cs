using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService()
        {
        }

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public void Add(Doctor model)
        {
            var people = new List<Doctor>();
            people.Add(null);
        }

        public Doctor Get(Guid id)
        {
            return _doctorRepository.Get(id);
        }

        public List<Doctor> GetAll()
        {
            return _doctorRepository.GetAll();
        }

        public void Remove(Doctor model)
        {
            _doctorRepository.Remove(model);
        }

        public void Update(Doctor model)
        {
            var oldDoctor = _doctorRepository.Get(model._id);
            var index = _doctorRepository.IndexOf(oldDoctor);
            _doctorRepository.Update(model, index);
        }
    }
}
