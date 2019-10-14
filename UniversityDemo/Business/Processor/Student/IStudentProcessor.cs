using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Student;

namespace UniversityDemo.Business.Processor.Student
{
    public interface IStudentProcessor
    {
        StudentResult Create(StudentParam param);
        List<StudentResult> Create(List<StudentParam> param);

        void Update(long id, StudentParam param);
        void Update(List<StudentParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        StudentResult Find(long id);
        List<StudentResult> Find();
    }
}
