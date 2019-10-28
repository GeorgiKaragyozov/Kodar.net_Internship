using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Lecture
{
    public class LectureDaoStorage
    {
        public static List<Model.Lecture> Lectures = new List<Model.Lecture>();

        public static IDictionary<long, Model.Lecture> Dictionary = new Dictionary<long, Model.Lecture>();

        static LectureDaoStorage()
        {
            Model.Lecture Lecture1 = new Model.Lecture()
            {

            };

            Model.Lecture Lecture2 = new Model.Lecture()
            {

            };

            Model.Lecture Lecture3 = new Model.Lecture()
            {

            };

            Lectures.Add(Lecture1);
            Lectures.Add(Lecture2);
            Lectures.Add(Lecture3);

            Dictionary.Add(Lecture1.Id, Lecture1);
            Dictionary.Add(Lecture2.Id, Lecture2);
            Dictionary.Add(Lecture3.Id, Lecture3);
        }
    }
}
