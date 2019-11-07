using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineResultConverter : IDisciplineResultConverter
    {
        public DisciplineResult Convert(Model.Discipline param)
        {
            DisciplineResult result = new DisciplineResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
