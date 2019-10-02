using System;
using System.Collections.Generic;
using UniversityDemo.Enums;

namespace UniversityDemo
{
    public class Speciality: NamedPersistent
    {
        private List<Student> _students;

        public List<Student> Students
        {
            get
            {
                if (this._students == null)
                {
                    throw new NullReferenceException();
                }

                return this._students;
            }
            set
            {
                this._students = value;
            }
        }

        public EducationalDegrees EducationalDegrees { get; set; }

        public TrainingType TrainingType { get; set; }

        public Speciality(EducationalDegrees educationalDegree, TrainingType trainingType) 
            : this(educationalDegree, trainingType, null) {}

        public Speciality(EducationalDegrees educationalDegree,
            TrainingType trainingType, List<Student> students)
        {
            this.EducationalDegrees = educationalDegree;
            this.TrainingType = trainingType;
            Students = students;
        }
    }
}
