namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineResult : BaseResultNamed
    {
        public long TeacherId { get; set; }
        public string TeacherName { get; set; }

        public long DisciplineId { get; set; }
        public string DisciplineName { get; set; }

        public long StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
