using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;

namespace UniversityDemo.Business.Processor.LectureStatus
{
    public interface ILectureStatusProcessor
    {
        LectureStatusResult Create(LectureStatusParam param);
        List<LectureStatusResult> Create(List<LectureStatusParam> param);

        void Update(long id, LectureStatusParam param);
        void Update(List<LectureStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        LectureStatusResult Find(long id);
        List<LectureStatusResult> Find();
    }
}
