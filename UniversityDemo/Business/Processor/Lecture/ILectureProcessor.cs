using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Lecture;

namespace UniversityDemo.Business.Processor.Lecture
{
    public interface ILectureProcessor
    {
        LectureResult Create(LectureParam param);
        List<LectureResult> Create(List<LectureParam> param);

        void Update(long id, LectureParam param);
        void Update(List<LectureParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        LectureResult Find(long id);
        List<LectureResult> Find();
    }
}
