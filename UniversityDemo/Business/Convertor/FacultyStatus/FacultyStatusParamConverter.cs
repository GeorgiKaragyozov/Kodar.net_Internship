using System;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        public IFacultyStatusDao Dao = new FacultyStatusDao();

        //public FacultyStatusParamConverter(IFacultyStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.FacultyStatus Convert(FacultyStatusParam param)
        {
            UniversityDemo.FacultyStatus entity = new UniversityDemo.FacultyStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.FacultyStatus Convert(FacultyStatusParam param,
        UniversityDemo.FacultyStatus oldEntity)
        {
            UniversityDemo.FacultyStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.FacultyStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
