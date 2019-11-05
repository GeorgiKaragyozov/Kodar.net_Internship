using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        ITeacherDisciplineStatusDao Dao = new TeacherDisciplineStatusDao();

        public Model.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param,
          Model.TeacherDisciplineStatus oldEntity)
        {
            Model.TeacherDisciplineStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.TeacherDisciplineStatus()
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
