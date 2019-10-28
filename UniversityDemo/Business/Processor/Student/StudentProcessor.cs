using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Student;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Processor.Student
{
    public class StudentProcessor : IStudentProcessor
    {
        public IStudentDao Dao = new StudentDao();

        public IStudentParamConverter ParamConverter = new StudentParamConverter();

        public IStudentResultConverter ResultConverter = new StudentResultConverter();

        //public StudentProcessor(IStudentDao dao, IStudentParamConverter paramConverter,
        //    IStudentResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public StudentResult Create(StudentParam param)
        {
            UniversityDemo.Student entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<StudentResult> Create(List<StudentParam> param)
        {
            List<UniversityDemo.Student> entities = new List<UniversityDemo.Student>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<StudentResult> result = new List<StudentResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.Student> entities = new List<UniversityDemo.Student>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public StudentResult Find(long id)
        {
            UniversityDemo.Student entity = Dao.Find(id);
            StudentResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<StudentResult> Find()
        {
            List<UniversityDemo.Student> entities = Dao.Find();

            List<StudentResult> results = new List<StudentResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, StudentParam param)
        {
            UniversityDemo.Student oldEntity = Dao.Find(id);

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

        public void Update(List<StudentParam> param)
        {
            //List<UniversityDemo.Student> entities = new List<UniversityDemo.Student>();

            foreach (var item in param)
            {
                UniversityDemo.Student oldEntity = Dao.Find(item.Id);
                UniversityDemo.Student newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
