using UniversityDemo.DataAccess.DataAccessObject.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        ISpecialityDao Dao = new SpecialityDao();

        ISpecialityStatusDao StatusDao = new SpecialityStatusDao();

        public Model.Speciality Convert(SpecialityParam param, Model.Speciality oldEntity)
        {
            Model.Speciality entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Speciality()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Status = StatusDao.Find(param.StatusId);
            entity.EducationalDegrees = param.EducationalDegrees;
            entity.TrainingType = param.TrainingType;

            return entity;
        }
    }
}
