namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureResultConverter : ILectureResultConverter
    {
        public LectureResult Convert(Model.Lecture param)
        {
            LectureResult result = new LectureResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,

                TeacherDisciplineId = param.TeacherDiscipline.Id,
                TeacherDisciplineName = param.TeacherDiscipline.Name,
                SpecialityId = param.Speciality.Id,
                SpecialityName = param.Speciality.Name,
                RoomId = param.Room.Id,
                RoomName = param.Room.Name,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
