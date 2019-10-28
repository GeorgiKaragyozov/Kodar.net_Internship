using System;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        public ISpecialityStatusDao Dao = new SpecialityStatusDao();

        //public SpecialityStatusParamConverter(ISpecialityStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param)
        {
            UniversityDemo.SpecialityStatus entity = new UniversityDemo.SpecialityStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param,
           UniversityDemo.SpecialityStatus oldEntity)
        {
            UniversityDemo.SpecialityStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.SpecialityStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
