using System;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParam : BaseParamNamed
    {
        public UniversityDemo.Teacher Teacher { get; set; }

        public UniversityDemo.Discipline Discipline { get; set; }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Status { get; set; }
    }
}
