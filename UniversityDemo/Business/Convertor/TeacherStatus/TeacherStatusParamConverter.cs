using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        ITeacherStatusDao Dao = new TeacherStatusDao();

        public Model.TeacherStatus Convert(TeacherStatusParam param,
          Model.TeacherStatus oldEntity)
        {
            Model.TeacherStatus entity = null;

            if (entity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.TeacherStatus()
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
