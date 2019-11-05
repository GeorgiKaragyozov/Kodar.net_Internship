using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        IDepartamentStatusDao Dao = new DepartamentStatusDao();

        public Model.DepartamentStatus Convert(DepartamentStatusParam param,
            Model.DepartamentStatus oldEntity)
        {
            Model.DepartamentStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.DepartamentStatus()
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
