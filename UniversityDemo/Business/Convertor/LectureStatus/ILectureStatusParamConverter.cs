namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusParamConverter
    {
        Data.Entity.Model.Status.LectureStatus Convert(LectureStatusParam param);
    }
}
