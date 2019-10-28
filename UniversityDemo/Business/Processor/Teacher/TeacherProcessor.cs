using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Processor.Teacher
{
    public class TeacherProcessor: ITeacherProcessor
    {
        public ITeacherDao Dao = new TeacherDao();

        public ITeacherParamConverter ParamConverter = new TeacherParamConverter();

        public ITeacherResultConverter ResultConverter = new TeacherResultConverter();

        //public TeacherProcessor(ITeacherDao dao, ITeacherParamConverter paramConverter,
        //    ITeacherResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public TeacherResult Create(TeacherParam param)
        {
            UniversityDemo.Teacher entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<TeacherResult> Create(List<TeacherParam> param)
        {
            List<UniversityDemo.Teacher> entities = new List<UniversityDemo.Teacher>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<TeacherResult> result = new List<TeacherResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.Teacher> entities = new List<UniversityDemo.Teacher>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public TeacherResult Find(long id)
        {
            UniversityDemo.Teacher entity = Dao.Find(id);
            TeacherResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<TeacherResult> Find()
        {
            List<UniversityDemo.Teacher> entities = Dao.Find();

            List<TeacherResult> results = new List<TeacherResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, TeacherParam param)
        {
            UniversityDemo.Teacher oldEntity = Dao.Find(id);

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

        public void Update(List<TeacherParam> param)
        {
            //List<UniversityDemo.Teacher> entities = new List<UniversityDemo.Teacher>();

            foreach (var item in param)
            {
                UniversityDemo.Teacher oldEntity = Dao.Find(item.Id);
                UniversityDemo.Teacher newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
