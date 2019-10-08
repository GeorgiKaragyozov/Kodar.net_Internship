using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        public TeacherStatusDao TeacherStatusDao { get; set; }
    }
}
