using System;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        public LectureDao Dao { get; set; }

        public Model.Lecture Convert(LectureParam param)
        {
            throw new NotImplementedException();
        }
    }
}
