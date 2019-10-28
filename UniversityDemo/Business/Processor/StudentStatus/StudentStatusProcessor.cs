using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.StudentStatus;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;

namespace UniversityDemo.Business.Processor.StudentStatus
{
    public class StudentStatusProcessor: IStudentStatusProcessor
    {
        public IStudentStatusDao Dao = new StudentStatusDao();

        public IStudentStatusParamConverter ParamConverter = new StudentStatusParamConverter();

        public IStudentStatusResultConverter ResultConverter = new StudentStatusResultConverter();

        //public StudentStatusProcessor(IStudentStatusDao dao, IStudentStatusParamConverter paramConverter,
        //    IStudentStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public StudentStatusResult Create(StudentStatusParam param)
        {
            UniversityDemo.StudentStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<StudentStatusResult> Create(List<StudentStatusParam> param)
        {
            List<UniversityDemo.StudentStatus> entities = new List<UniversityDemo.StudentStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<StudentStatusResult> result = new List<StudentStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.StudentStatus> entities = new List<UniversityDemo.StudentStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public StudentStatusResult Find(long id)
        {
            UniversityDemo.StudentStatus entity = Dao.Find(id);
            StudentStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<StudentStatusResult> Find()
        {
            List<UniversityDemo.StudentStatus> entities = Dao.Find();

            List<StudentStatusResult> results = new List<StudentStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, StudentStatusParam param)
        {
            UniversityDemo.StudentStatus oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                Dao.Delete(oldEntity);
                Dao.Update(ParamConverter.Convert(param));
            }
            else
            {
                Console.WriteLine($"No entity with Id = {id}  was found");
            }
        }

        public void Update(List<StudentStatusParam> param)
        {
            //List<UniversityDemo.StudentStatus> entities = new List<UniversityDemo.StudentStatus>();

            foreach (var item in param)
            {
                UniversityDemo.StudentStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.StudentStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
