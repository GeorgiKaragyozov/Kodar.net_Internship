using System;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.UserStatus
{
    public class UserStatusProcessor: IUserStatusProcessor
    {
        public TeacherStatusDao TeacherDao { get; set; }

        public TeacherStatusParamConverter TeacherParamConverter { get; set; }

        public TeacherStatusResultConverter TeacherResultConverter { get; set; }
    }
}
