namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentResult : BaseResultNamed
    {
        public long TeacherId { get; set; }
        public string TeacherName { get; set; }

        public long SpecialityId { get; set; }
        public string SpecialityName { get; set; }


        public long StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
