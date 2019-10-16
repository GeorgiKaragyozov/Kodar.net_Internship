using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.StudentStatus;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Processor.StudentStatus
{
    public class StudentStatusProcessor: IStudentStatusProcessor
    {
        public StudentStatusDao Dao { get; set; }

        public StudentStatusParamConverter ParamConverter { get; set; }

        public StudentStatusResultConverter ResultConverter { get; set; }

        public StudentStatusResult Create(StudentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<StudentStatusResult> Create(List<StudentStatusParam> param)
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

        public StudentStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<StudentStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, StudentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<StudentStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
