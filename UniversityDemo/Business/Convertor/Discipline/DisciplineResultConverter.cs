using System;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineResultConverter : IDisciplineResultConverter
    {
        public DisciplineResult Convert(UniversityDemo.Discipline param)
        {
            DisciplineResult result = new DisciplineResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status
            };

            return result;
        }
    }
}
