using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Lecture;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Processor.Lecture
{
    public class LectureProcessor: ILectureProcessor
    {
        public ILectureDao Dao { get; set; }

        public ILectureParamConverter ParamConverter { get; set; }

        public ILectureResultConverter ResultConverter { get; set; }

        public LectureProcessor(ILectureDao dao, ILectureParamConverter paramConverter,
            ILectureResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public LectureResult Create(LectureParam param)
        {
            throw new NotImplementedException();
        }

        public List<LectureResult> Create(List<LectureParam> param)
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

        public LectureResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<LectureResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, LectureParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<LectureParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
