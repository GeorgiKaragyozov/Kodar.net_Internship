using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        public TeacherStatusDao Dao { get; set; }

        public Model.Accounts.TeacherStatus Convert(TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
