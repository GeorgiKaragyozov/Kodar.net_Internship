using System;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        public ISpecialityDao Dao = new SpecialityDao();

        //public SpecialityParamConverter(ISpecialityDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Speciality Convert(SpecialityParam param)
        {
            UniversityDemo.Speciality entity = new UniversityDemo.Speciality()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                EducationalDegrees  = param.EducationalDegrees,
                TrainingType = param.TrainingType
            };

            return entity;
        }

        public UniversityDemo.Speciality Convert(SpecialityParam param,
           UniversityDemo.Speciality oldEntity)
        {
            UniversityDemo.Speciality entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Speciality();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;
            entity.EducationalDegrees = param.EducationalDegrees;
            entity.TrainingType = param.TrainingType;

            return entity;
        }
    }
}
