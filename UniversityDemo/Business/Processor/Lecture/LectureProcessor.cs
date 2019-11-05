using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Lecture;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Processor.Lecture
{
    public class LectureProcessor: ILectureProcessor
    {
        public ILectureDao Dao = new LectureDao();

        public ILectureParamConverter ParamConverter = new LectureParamConverter();

        public ILectureResultConverter ResultConverter = new LectureResultConverter();

        //public LectureProcessor(ILectureDao dao, ILectureParamConverter paramConverter,
        //    ILectureResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public LectureResult Create(LectureParam param)
        {
            Model.Lecture entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<LectureResult> Create(List<LectureParam> param)
        {
            List<Model.Lecture> entities = new List<Model.Lecture>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<LectureResult> result = new List<LectureResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.Lecture> entities = new List<Model.Lecture>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public LectureResult Find(long id)
        {
            Model.Lecture entity = Dao.Find(id);
            LectureResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<LectureResult> Find()
        {
            List<Model.Lecture> entities = Dao.Find();

            List<LectureResult> results = new List<LectureResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, LectureParam param)
        {
            Model.Lecture oldEntity = Dao.Find(id);

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

        public void Update(List<LectureParam> param)
        {
            //List<Model.Lecture> entities = new List<Model.Lecture>();

            foreach (var item in param)
            {
                Model.Lecture oldEntity = Dao.Find(item.Id);
                Model.Lecture newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
