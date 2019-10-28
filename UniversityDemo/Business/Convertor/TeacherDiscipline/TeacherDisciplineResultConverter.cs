using System;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineResultConverter : ITeacherDisciplineResultConverter
    {
        public TeacherDisciplineResult Convert(Model.TeacherDiscipline param)
        {
            TeacherDisciplineResult result = new TeacherDisciplineResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                Teacher = param.Teacher,
                Discipline = param.Discipline
            };

            return result;
        }
    }
}
