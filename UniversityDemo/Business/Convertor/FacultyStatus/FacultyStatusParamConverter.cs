using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        IFacultyStatusDao Dao = new FacultyStatusDao();

        public Model.FacultyStatus Convert(FacultyStatusParam param,
        Model.FacultyStatus oldEntity)
        {
            Model.FacultyStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.FacultyStatus
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
