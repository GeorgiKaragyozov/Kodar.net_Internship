﻿using System;
using UniversityDemo.Business.Processor.Speciality;

namespace UniversityDemo.Presentation.Service.Speciality
{
    public class SpecialityService: ISpecialityService
    {
        public SpecialityProcessor Processor { get; set; }
    }
}
