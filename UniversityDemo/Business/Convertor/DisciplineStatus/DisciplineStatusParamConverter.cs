using System;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        public IDisciplineStatusDao Dao = new DisciplineStatusDao();

        //public DisciplineStatusParamConverter(IDisciplineStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param)
        {
            UniversityDemo.DisciplineStatus entity = new UniversityDemo.DisciplineStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param,
         UniversityDemo.DisciplineStatus oldEntity)
        {
            UniversityDemo.DisciplineStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.DisciplineStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
