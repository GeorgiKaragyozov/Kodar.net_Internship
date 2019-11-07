using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        IDisciplineStatusDao Dao = new DisciplineStatusDao();

        public Model.DisciplineStatus Convert(DisciplineStatusParam param,
         Model.DisciplineStatus oldEntity)
        {
            Model.DisciplineStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.DisciplineStatus
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
