using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        IStudentStatusDao Dao = new StudentStatusDao();

        public Model.StudentStatus Convert(StudentStatusParam param, Model.StudentStatus oldEntity)
        {
            Model.StudentStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.StudentStatus()
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
