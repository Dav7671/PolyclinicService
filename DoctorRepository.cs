using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    class DoctorRepository : BaseRepository<Doctor>,IDoctorRepository
    {
        public override Doctor Get(Guid id)
        {
            return models.FirstOrDefault(x => x._id == id);
        }
    }
}
