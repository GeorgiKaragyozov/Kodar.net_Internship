namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureResult : BaseResultNamed
    {
        public long TeacherDisciplineId { get; set; }
        public string TeacherDisciplineName { get; set; }

        public long SpecialityId { get; set; }
        public string SpecialityName { get; set; }

        public long RoomId { get; set; }
        public string RoomName { get; set; }

        public long StatusId { get; set; }
        public string StatusName { get; set; }
    }
}

