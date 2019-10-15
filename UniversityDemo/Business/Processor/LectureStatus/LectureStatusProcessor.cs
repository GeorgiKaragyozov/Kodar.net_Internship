using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Processor.LectureStatus
{
    public class LectureStatusProcessor: ILectureStatusProcessor
    {
         public LectureStatusDao LectureStatusDao { get; set; }

        public LectureStatusParamConverter LectureStatusParamConverter { get; set; }

        public LectureStatusResultConverter LectureStatusResultConverter { get; set; }

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
