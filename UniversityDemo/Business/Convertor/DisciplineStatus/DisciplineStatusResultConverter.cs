using System;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusResultConverter : IDisciplineStatusResultConverter
    {
        public DisciplineStatusResult Convert(UniversityDemo.DisciplineStatus param)
        {
            DisciplineStatusResult result = new DisciplineStatusResult()
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
