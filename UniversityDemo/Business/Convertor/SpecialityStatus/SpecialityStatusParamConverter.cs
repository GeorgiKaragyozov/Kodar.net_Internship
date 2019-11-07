using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        ISpecialityStatusDao Dao = new SpecialityStatusDao();

        public Model.SpecialityStatus Convert(SpecialityStatusParam param,
           Model.SpecialityStatus oldEntity)
        {
            Model.SpecialityStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.SpecialityStatus()
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
