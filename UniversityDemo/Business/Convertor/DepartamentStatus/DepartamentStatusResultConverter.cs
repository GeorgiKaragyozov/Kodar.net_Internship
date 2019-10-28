using System;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusResultConverter : IDepartamentStatusResultConverter
    {
        public DepartamentStatusResult Convert(UniversityDemo.DepartamentStatus param)
        {
            DepartamentStatusResult result = new DepartamentStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return result;
        }
    }
}
