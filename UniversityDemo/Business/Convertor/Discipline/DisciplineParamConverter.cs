using System;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        public IDisciplineDao Dao = new DisciplineDao();

        //public DisciplineParamConverter(IDisciplineDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Discipline Convert(DisciplineParam param)
        {
            UniversityDemo.Discipline entity = new UniversityDemo.Discipline()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status
            };

            return entity;
        }

        public UniversityDemo.Discipline Convert(DisciplineParam param,
          UniversityDemo.Discipline oldEntity)
        {
            UniversityDemo.Discipline entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Discipline();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;

            return entity;
        }
    }
}
