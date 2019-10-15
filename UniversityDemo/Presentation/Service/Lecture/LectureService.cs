using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Lecture;
using UniversityDemo.Business.Processor.Lecture;

namespace UniversityDemo.Presentation.Service.Lecture
{
    public class LectureService: ILectureProcessor
    {
        public LectureProcessor Processor { get; set; }

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
