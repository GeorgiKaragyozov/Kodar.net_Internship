using System;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        public IFacultyStatusDao Dao { get; set; }

        public FacultyStatusParamConverter(IFacultyStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.FacultyStatus Convert(FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
