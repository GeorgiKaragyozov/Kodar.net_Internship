﻿namespace UniversityDemo.Model
{
    public class TeacherDiscipline : NamedPersistent
    {
        public Teacher Teacher { get; set; }

        public Discipline Discipline { get; set; }

        public TeacherDisciplineStatus Status { get; set; }
    }
}
