using System;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusParamConverter: IStudentStatusParamConverter
    {
        public IStudentStatusDao Dao = new StudentStatusDao();

        //public StudentStatusParamConverter(IStudentStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.StudentStatus Convert(StudentStatusParam param)
        {
            UniversityDemo.StudentStatus entity = new UniversityDemo.StudentStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.StudentStatus Convert(StudentStatusParam param,
          UniversityDemo.StudentStatus oldEntity)
        {
            UniversityDemo.StudentStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.StudentStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
