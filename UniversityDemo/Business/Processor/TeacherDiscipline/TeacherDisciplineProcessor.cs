using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Processor.TeacherDiscipline
{
    public class TeacherDisciplineProcessor: ITeacherDisciplineProcessor
    {
        public ITeacherDisciplineDao Dao = new TeacherDisciplineDao();

        public ITeacherDisciplineParamConverter ParamConverter = new TeacherDisciplineParamConverter();

        public ITeacherDisciplineResultConverter ResultConverter = new TeacherDisciplineResultConverter();

        //public TeacherDisciplineProcessor(ITeacherDisciplineDao dao,
        //    ITeacherDisciplineParamConverter paramConverter,
        //    ITeacherDisciplineResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public TeacherDisciplineResult Create(TeacherDisciplineParam param)
        {
            Model.TeacherDiscipline entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<TeacherDisciplineResult> Create(List<TeacherDisciplineParam> param)
        {
            List<Model.TeacherDiscipline> entities = new List<Model.TeacherDiscipline>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<TeacherDisciplineResult> result = new List<TeacherDisciplineResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.TeacherDiscipline> entities = new List<Model.TeacherDiscipline>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }
                
            Dao.Delete(idList);
        }

        public TeacherDisciplineResult Find(long id)
        {
            Model.TeacherDiscipline entity = Dao.Find(id);
            TeacherDisciplineResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<TeacherDisciplineResult> Find()
        {
            List<Model.TeacherDiscipline> entities = Dao.Find();

            List<TeacherDisciplineResult> results = new List<TeacherDisciplineResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, TeacherDisciplineParam param)
        {
            Model.TeacherDiscipline oldEntity = Dao.Find(id);

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

        public void Update(List<TeacherDisciplineParam> param)
        {
            //List< Model.TeacherDiscipline> entities = new List< Model.TeacherDiscipline>();

            foreach (var item in param)
            {
                Model.TeacherDiscipline oldEntity = Dao.Find(item.Id);
                Model.TeacherDiscipline newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
