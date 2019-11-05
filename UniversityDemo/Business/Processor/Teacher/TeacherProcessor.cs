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
            Model.Teacher entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<TeacherResult> Create(List<TeacherParam> param)
        {
            List<Model.Teacher> entities = new List<Model.Teacher>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
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
            List<Model.Teacher> entities = new List<Model.Teacher>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public TeacherResult Find(long id)
        {
            Model.Teacher entity = Dao.Find(id);
            TeacherResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<TeacherResult> Find()
        {
            List<Model.Teacher> entities = Dao.Find();

            List<TeacherResult> results = new List<TeacherResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, TeacherParam param)
        {
            Model.Teacher oldEntity = Dao.Find(id);

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

        public void Update(List<TeacherParam> param)
        {
            //List<UniversityDemo.Teacher> entities = new List<UniversityDemo.Teacher>();

            foreach (var item in param)
            {
                Model.Teacher oldEntity = Dao.Find(item.Id);
                Model.Teacher newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
