using UniversityDemo.DataAccess.DataAccessObject.Discipline;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        IDisciplineDao Dao = new DisciplineDao();

        IDisciplineStatusDao StatusDao = new DisciplineStatusDao();

        public Model.Discipline Convert(DisciplineParam param,
          Model.Discipline oldEntity)
        {
            Model.Discipline entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Discipline
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
