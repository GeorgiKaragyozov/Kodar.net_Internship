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
            Model.StudentStatus entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<StudentStatusResult> Create(List<StudentStatusParam> param)
        {
            List<Model.StudentStatus> entities = new List<Model.StudentStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
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
            List<Model.StudentStatus> entities = new List<Model.StudentStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public StudentStatusResult Find(long id)
        {
            Model.StudentStatus entity = Dao.Find(id);
            StudentStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<StudentStatusResult> Find()
        {
            List<Model.StudentStatus> entities = Dao.Find();

            List<StudentStatusResult> results = new List<StudentStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, StudentStatusParam param)
        {
            Model.StudentStatus oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                Dao.Delete(oldEntity);
                Dao.Update(ParamConverter.Convert(param, null));
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
                Model.StudentStatus oldEntity = Dao.Find(item.Id);
                Model.StudentStatus newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
