using System;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        public FacultyStatusDao Dao { get; set; }

        public UniversityDemo.FacultyStatus Convert(FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
