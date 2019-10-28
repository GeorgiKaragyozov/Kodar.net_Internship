using System;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        public IDepartamentStatusDao Dao = new DepartamentStatusDao();

        //public DepartamentStatusParamConverter(IDepartamentStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param)
        {
            UniversityDemo.DepartamentStatus entity = new UniversityDemo.DepartamentStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param,
            UniversityDemo.DepartamentStatus oldEntity)
        {
            UniversityDemo.DepartamentStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.DepartamentStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
