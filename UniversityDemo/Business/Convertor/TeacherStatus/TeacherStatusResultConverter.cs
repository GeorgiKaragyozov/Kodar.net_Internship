namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusResultConverter : ITeacherStatusResultConverter
    {
        public TeacherStatusResult Convert(Model.TeacherStatus param)
        {
            TeacherStatusResult result = new TeacherStatusResult()
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
