using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public class Patient
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Doctor _doctor;

        public Patient()
        {
            _id = Guid.NewGuid();
        }

        public Patient(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
    }
}
