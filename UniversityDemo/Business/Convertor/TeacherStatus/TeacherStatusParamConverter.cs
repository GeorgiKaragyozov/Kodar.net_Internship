using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        public ITeacherStatusDao Dao = new TeacherStatusDao();

        //public TeacherStatusParamConverter(ITeacherStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public Model.Accounts.TeacherStatus Convert(TeacherStatusParam param)
        {
            Model.Accounts.TeacherStatus entity = new Model.Accounts.TeacherStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public Model.Accounts.TeacherStatus Convert(TeacherStatusParam param,
          Model.Accounts.TeacherStatus oldEntity)
        {
            Model.Accounts.TeacherStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new Model.Accounts.TeacherStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
