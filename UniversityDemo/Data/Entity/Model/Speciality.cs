﻿using UniversityDemo.Enums;

namespace UniversityDemo.Model
{
    public class Speciality: NamedPersistent
    {
        public SpecialityStatus Status { get; set; }

        public EducationalDegrees EducationalDegrees { get; set; }

        public TrainingType TrainingType { get; set; }

        //public Speciality(EducationalDegrees educationalDegree, TrainingType trainingType)
        //{
        //    this.EducationalDegrees = educationalDegree;
        //    this.TrainingType = trainingType;
        //}          
    }
}
