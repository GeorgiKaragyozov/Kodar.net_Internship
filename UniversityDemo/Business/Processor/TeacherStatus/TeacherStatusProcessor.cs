using System;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.TeacherStatus
{
    public class TeacherStatusProcessor: ITeacherStatusProcessor
    {
        public TeacherStatusDao TeacherDao { get; set; }

        public TeacherStatusParamConverter TeacherParamConverter { get; set; }

        public TeacherStatusResultConverter TeacherResultConverter { get; set; }
    }
}
