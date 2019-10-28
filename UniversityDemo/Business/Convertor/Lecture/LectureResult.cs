using System;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureResult : BaseResultNamed
    {
        public Model.TeacherDiscipline TeacherDiscipline { get; set; }

        public UniversityDemo.Speciality Speciality { get; set; }

        public UniversityDemo.Room Room { get; set; }

        public Data.Entity.Model.Status.LectureStatus Status { get; set; }
    }
}

