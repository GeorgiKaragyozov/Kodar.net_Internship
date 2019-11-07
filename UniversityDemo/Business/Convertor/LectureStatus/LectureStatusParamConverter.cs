using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        ILectureStatusDao Dao = new LectureStatusDao();

        public Model.LectureStatus Convert(LectureStatusParam param,
           Model.LectureStatus oldEntity)
        {
            Model.LectureStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.LectureStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            return entity;
        }
    }
}
