using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private List<Patient> _patients;

        public override Patient Get(Guid id)
        {
            return models.FirstOrDefault(x => x._id == id);
        }

        internal void Add(Patient patient, int v)
        {
            throw new NotImplementedException();
        }
        public Enumerator GetEnumerator()
        {
            return new Enumerator(_patients, _patients.Count);
        }
        public class Enumerator
        {
            public Enumerator(List<Patient> patient, int size)
            {
                _patients = patient;
                _size = size;
            }
            private int _size;
            private int _count;
            private List<Patient> _patients;

            public Patient Current { get { return _patients[_count++]; } }
                public bool MoveNext()
            {
                return _count < _size;
            }
            
        }
    }
}
