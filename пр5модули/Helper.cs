using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр5модули.Models;

namespace пр5модули
{
    internal class Helper
    {
        private static HospitalProEntities _context;


        public static HospitalProEntities GetContext()
        {
            if (_context == null)
            { 
            _context = new HospitalProEntities();
            }
            return _context;
        }

        public void CreatePatient(Patient patient)
        { 
            _context.Patient.Add(patient);

            _context.SaveChanges();
        }
    }
}
