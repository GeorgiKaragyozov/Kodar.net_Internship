using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.StudentStatus;

namespace UniversityDemo.Business.Processor.StudentStatus
{
    public interface IStudentStatusProcessor
    {
        StudentStatusResult Create(StudentStatusParam param);
        List<StudentStatusResult> Create(List<StudentStatusParam> param);

        void Update(long id, StudentStatusParam param);
        void Update(List<StudentStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        StudentStatusResult Find(long id);
        List<StudentStatusResult> Find();
    }
}
