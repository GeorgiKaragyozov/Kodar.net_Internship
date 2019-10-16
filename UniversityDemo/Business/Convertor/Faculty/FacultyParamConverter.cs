using System;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        public FacultyDao Dao { get; set; }

        public UniversityDemo.Faculty Convert(FacultyParam param)
        {
            throw new NotImplementedException();
        }
    }
}
