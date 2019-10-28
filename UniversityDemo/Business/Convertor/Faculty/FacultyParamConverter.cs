using System;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        public IFacultyDao Dao = new FacultyDao();

        //public FacultyParamConverter(IFacultyDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Faculty Convert(FacultyParam param)
        {
            UniversityDemo.Faculty entity = new UniversityDemo.Faculty()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Departament = param.Departament
            };

            return entity;
        }

        public UniversityDemo.Faculty Convert(FacultyParam param,
         UniversityDemo.Faculty oldEntity)
        {
            UniversityDemo.Faculty entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Faculty();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Departament = param.Departament;

            return entity;
        }
    }
}
