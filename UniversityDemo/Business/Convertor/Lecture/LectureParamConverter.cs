using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;
using UniversityDemo.Model;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        public LectureDao LectureDao { get; set; }

        public Model.Lecture Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
