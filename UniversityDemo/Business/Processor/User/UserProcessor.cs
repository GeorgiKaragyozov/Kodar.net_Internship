using System;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Processor.User
{
    public class UserProcessor: IUserProcessor
    {
        public TeacherDao TeacherDao { get; set; }

        public TeacherParamConverter TeacherParamConverter { get; set; }

        public TeacherResultConverter TeacherResultConverter { get; set; }
    }
}
