using System;
using UniversityDemo.Data.Entity.Model.Status;

namespace UniversityDemo.Model
{
    public class Lecture : NamedPersistent
    {
        public TeacherDiscipline TeacherDiscipline { get; set; }

        public Speciality Speciality { get; set; }

        public Room Room { get; set; }

        public LectureStatus Status { get; set; }
    }
}
