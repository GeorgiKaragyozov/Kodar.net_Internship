namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyResult : BaseResultNamed
    {
        public long DepartamentId { get; set; }
        public string DepartamentName { get; set; }

        public long StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
