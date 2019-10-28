using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public class SpecialityDaoStorage
    {
        public static List<UniversityDemo.Speciality> Specialities = new List<UniversityDemo.Speciality>();

        public static IDictionary<long, UniversityDemo.Speciality> Dictionary =
            new Dictionary<long, UniversityDemo.Speciality>();

        static SpecialityDaoStorage()
        {
            UniversityDemo.Speciality speciality1 = new UniversityDemo.Speciality()
            {

            };

            UniversityDemo.Speciality speciality2 = new UniversityDemo.Speciality()
            {

            };

            UniversityDemo.Speciality speciality3 = new UniversityDemo.Speciality()
            {

            };

            Specialities.Add(speciality1);
            Specialities.Add(speciality2);
            Specialities.Add(speciality3);

            Dictionary.Add(speciality1.Id, speciality1);
            Dictionary.Add(speciality2.Id, speciality2);
            Dictionary.Add(speciality3.Id, speciality3);
        }
    }
}
