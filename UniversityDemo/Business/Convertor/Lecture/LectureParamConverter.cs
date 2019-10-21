using System;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        public ILectureDao Dao { get; set; }

        public LectureParamConverter(ILectureDao dao)
        {
            this.Dao = dao;
        }

        public Model.Lecture Convert(LectureParam param)
        {
            throw new NotImplementedException();
        }
    }
}
