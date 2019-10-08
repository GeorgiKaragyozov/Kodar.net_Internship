using System;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Processor.Teacher
{
    public class TeacherProcessor: ITeacherProcessor
    {
        public TeacherDao TeacherDao { get; set; }

        public TeacherParamConverter TeacherParamConverter { get; set; }

        public TeacherResultConverter TeacherResultConverter { get; set; }
    }
}
