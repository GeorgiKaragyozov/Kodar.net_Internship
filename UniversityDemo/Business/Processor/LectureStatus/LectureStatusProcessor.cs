using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Processor.LectureStatus
{
    public class LectureStatusProcessor: ILectureStatusProcessor
    {
        public ILectureStatusDao Dao { get; set; }

        public ILectureStatusParamConverter ParamConverter { get; set; }

        public ILectureStatusResultConverter ResultConverter { get; set; }

        public LectureStatusProcessor(ILectureStatusDao dao, ILectureStatusParamConverter paramConverter,
           ILectureStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public LectureStatusResult Create(LectureStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<LectureStatusResult> Create(List<LectureStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public LectureStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<LectureStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, LectureStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<LectureStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
