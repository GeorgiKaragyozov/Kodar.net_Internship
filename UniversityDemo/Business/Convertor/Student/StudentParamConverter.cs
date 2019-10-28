using System;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        public IStudentDao Dao = new StudentDao();

        //public StudentParamConverter(IStudentDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Student Convert(StudentParam param)
        {
            UniversityDemo.Student entity = new UniversityDemo.Student()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                Speciality = param.Speciality,
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

        public UniversityDemo.Student Convert(StudentParam param,
          UniversityDemo.Student oldEntity)
        {
            UniversityDemo.Student entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Student();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;
            entity.Speciality = param.Speciality;
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
