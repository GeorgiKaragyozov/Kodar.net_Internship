using System;

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
                TeacherDiscipline = param.TeacherDiscipline,
                Speciality = param.Speciality,
                Room = param.Room,
                Status = param.Status
            };

            return result;
        }
    }
}
