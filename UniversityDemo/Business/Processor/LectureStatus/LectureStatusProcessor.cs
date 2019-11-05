using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Processor.LectureStatus
{
    public class LectureStatusProcessor: ILectureStatusProcessor
    {
        public ILectureStatusDao Dao = new LectureStatusDao();

        public ILectureStatusParamConverter ParamConverter = new LectureStatusParamConverter();

        public ILectureStatusResultConverter ResultConverter = new LectureStatusResultConverter();

        //public LectureStatusProcessor(ILectureStatusDao dao, ILectureStatusParamConverter paramConverter,
        //   ILectureStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public LectureStatusResult Create(LectureStatusParam param)
        {
            Model.LectureStatus entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<LectureStatusResult> Create(List<LectureStatusParam> param)
        {
            List<Model.LectureStatus> entities = new List<Model.LectureStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<LectureStatusResult> result = new List<LectureStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.LectureStatus> entities = new List<Model.LectureStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public LectureStatusResult Find(long id)
        {
            Model.LectureStatus entity = Dao.Find(id);
            LectureStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<LectureStatusResult> Find()
        {
            List<Model.LectureStatus> entities = Dao.Find();

            List<LectureStatusResult> results = new List<LectureStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, LectureStatusParam param)
        {
            Model.LectureStatus oldEntity = Dao.Find(id);

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

        public void Update(List<LectureStatusParam> param)
        {
            //List<Data.Entity.Model.Status.LectureStatus> entities = new List<Data.Entity.Model.Status.LectureStatus>();

            foreach (var item in param)
            {
                Model.LectureStatus oldEntity = Dao.Find(item.Id);
                Model.LectureStatus newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
