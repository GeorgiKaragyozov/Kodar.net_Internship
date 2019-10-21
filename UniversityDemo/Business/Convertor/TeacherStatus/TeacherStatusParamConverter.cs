using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        public ITeacherStatusDao Dao { get; set; }

        public TeacherStatusParamConverter(ITeacherStatusDao dao)
        {
            this.Dao = dao;
        }

        public Model.Accounts.TeacherStatus Convert(TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
