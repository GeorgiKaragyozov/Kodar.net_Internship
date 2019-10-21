using System;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        public IFacultyDao Dao { get; set; }

        public FacultyParamConverter(IFacultyDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Faculty Convert(FacultyParam param)
        {
            throw new NotImplementedException();
        }
    }
}
