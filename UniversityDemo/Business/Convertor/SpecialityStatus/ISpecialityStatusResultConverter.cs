﻿using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public interface ISpecialityStatusResultConverter
    {
        SpecialityStatusResult Convert(Model.SpecialityStatus param);
    }
}
