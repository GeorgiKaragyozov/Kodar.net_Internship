using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        public FacultyDao FacultyDao { get; set; }

        public UniversityDemo.Faculty Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
