using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public class Doctor
    {
        public Guid _id;
        public string _name;
        public int _age;
        public List<Patient> _patients;

        public Doctor()
        {
            _id = Guid.NewGuid();
        }

        public Doctor(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _patients = new List<Patient>();
        }
    }
}
