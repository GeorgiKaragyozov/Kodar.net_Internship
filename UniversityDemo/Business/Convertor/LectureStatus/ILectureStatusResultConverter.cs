namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusResultConverter
    {
        LectureStatusResult Convert(Data.Entity.Model.Status.LectureStatus param);
    }
}
