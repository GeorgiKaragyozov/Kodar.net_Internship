﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Discipline;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Processor.Discipline
{
    public class DisciplineProcessor: IDisciplineProcessor
    {
        public IDisciplineDao Dao = new DisciplineDao();

        public IDisciplineParamConverter ParamConverter = new DisciplineParamConverter();

        public IDisciplineResultConverter ResultConverter = new DisciplineResultConverter();

        //public DisciplineProcessor(IDisciplineDao dao, IDisciplineParamConverter paramConverter,
        //    IDisciplineResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public DisciplineResult Create(DisciplineParam param)
        {
            UniversityDemo.Discipline entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<DisciplineResult> Create(List<DisciplineParam> param)
        {
            List<UniversityDemo.Discipline> entities = new List<UniversityDemo.Discipline>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<DisciplineResult> result = new List<DisciplineResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.Discipline> entities = new List<UniversityDemo.Discipline>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public DisciplineResult Find(long id)
        {
            UniversityDemo.Discipline entity = Dao.Find(id);
            DisciplineResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<DisciplineResult> Find()
        {
            List<UniversityDemo.Discipline> entities = Dao.Find();

            List<DisciplineResult> results = new List<DisciplineResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, DisciplineParam param)
        {
            UniversityDemo.Discipline oldEntity = Dao.Find(id);

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

        public void Update(List<DisciplineParam> param)
        {
            //List<UniversityDemo.Discipline> entities = new List<UniversityDemo.Discipline>();

            foreach (var item in param)
            {
                UniversityDemo.Discipline oldEntity = Dao.Find(item.Id);
                UniversityDemo.Discipline newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
