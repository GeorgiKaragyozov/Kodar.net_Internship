using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusResultConverter : ITeacherDisciplineStatusResultConverter
    {
        public TeacherDisciplineStatusResult Convert(Model.TeacherDisciplineStatus param)
        {
            TeacherDisciplineStatusResult result = new TeacherDisciplineStatusResult()
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
