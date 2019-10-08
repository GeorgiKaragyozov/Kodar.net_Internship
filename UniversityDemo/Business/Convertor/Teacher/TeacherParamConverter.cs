using System;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        public TeacherDao TeacherDao { get; set; }
    }
}
