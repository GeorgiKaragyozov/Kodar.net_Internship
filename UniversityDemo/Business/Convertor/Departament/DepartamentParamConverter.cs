using System;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        public IDepartamentDao Dao = new DepartamentDao();

        //public DepartamentParamConverter(IDepartamentDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Departament Convert(DepartamentParam param)
        {
            UniversityDemo.Departament entity = new UniversityDemo.Departament()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Speciality = param.Speciality,
                Teacher = param.Teacher,
                Status = param.Status
            };

            return entity;
        }

        public UniversityDemo.Departament Convert(DepartamentParam param, UniversityDemo.Departament oldEntity)
        {
            UniversityDemo.Departament entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Departament();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Speciality = param.Speciality;
            entity.Teacher = param.Teacher;
            entity.Status = param.Status;

            return entity;
        }
    }
}
