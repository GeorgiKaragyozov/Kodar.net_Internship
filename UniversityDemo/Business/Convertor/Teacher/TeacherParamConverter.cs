using System;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        public ITeacherDao Dao = new TeacherDao();

        //public TeacherParamConverter(ITeacherDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Teacher Convert(TeacherParam param)
        {
            UniversityDemo.Teacher entity = new UniversityDemo.Teacher()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                FirstName = param.FirstName,
                MiddleName = param.MiddleName,
                LastName = param.LastName,
                Egn = param.Egn,
                Address = param.Address,
                Country = param.Country,
                MobilePhone = param.MobilePhone,
                HomePhone = param.HomePhone,
                User = param.User,
            };

            return entity;
        }

        public UniversityDemo.Teacher Convert(TeacherParam param,
          UniversityDemo.Teacher oldEntity)
        {
            UniversityDemo.Teacher entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Teacher();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;
            entity.FirstName = param.FirstName;
            entity.LastName = param.LastName;
            entity.MiddleName = param.MiddleName;
            entity.Address = param.Address;
            entity.MobilePhone = param.MobilePhone;
            entity.HomePhone = param.HomePhone;
            entity.Email = param.Email;
            entity.User = param.User;

            return entity;
        }
    }
}
