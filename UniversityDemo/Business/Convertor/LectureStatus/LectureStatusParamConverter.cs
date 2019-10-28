using System;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        public ILectureStatusDao Dao = new LectureStatusDao();

        //public LectureStatusParamConverter(ILectureStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public Data.Entity.Model.Status.LectureStatus Convert(LectureStatusParam param)
        {
            Data.Entity.Model.Status.LectureStatus entity = new Data.Entity.Model.Status.LectureStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public Data.Entity.Model.Status.LectureStatus Convert(LectureStatusParam param, 
            Data.Entity.Model.Status.LectureStatus oldEntity)
        {
            Data.Entity.Model.Status.LectureStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new Data.Entity.Model.Status.LectureStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
