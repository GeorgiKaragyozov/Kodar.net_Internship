namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyResultConverter : IFacultyResultConverter
    {
        public FacultyResult Convert(Model.Faculty param)
        {
            FacultyResult result = new FacultyResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,

                DepartamentId = param.Departament.Id,
                DepartamentName = param.Departament.Name,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
