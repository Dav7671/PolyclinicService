using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientRepository patients = new PatientRepository();
            Patient patient = new Patient("Ashot",18);
            Patient patient1 = new Patient("Ashot",18);
            Patient patient2 = new Patient("Ashot",18);
            Patient patient3 = new Patient("Ashot",18);
            List<Patient> _patients = new List<Patient> { patient, patient1, patient2, patient3 };
            foreach (var item in _patients)
            {
                Console.WriteLine($"Patient's name = {_patients}");
            }
           
            Console.ReadKey();
        }
    }
}
