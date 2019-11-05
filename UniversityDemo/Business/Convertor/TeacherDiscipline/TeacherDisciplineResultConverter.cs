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

                TeacherId = param.Teacher.Id,
                TeacherName = param.Teacher.Name,
                DisciplineId = param.Discipline.Id,
                DisciplineName = param.Discipline.Name,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
