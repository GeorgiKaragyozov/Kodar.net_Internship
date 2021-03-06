﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Processor.Speciality
{
    public class SpecialityProcessor : ISpecialityProcessor
    {
        public ISpecialityDao Dao = new SpecialityDao();

        public ISpecialityParamConverter ParamConverter = new SpecialityParamConverter();

        public ISpecialityResultConverter ResultConverter = new SpecialityResultConverter();

        //public SpecialityProcessor(ISpecialityDao dao, ISpecialityParamConverter paramConverter,
        //    ISpecialityResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public SpecialityResult Create(SpecialityParam param)
        {
            Model.Speciality entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<SpecialityResult> Create(List<SpecialityParam> param)
        {
            List<Model.Speciality> entities = new List<Model.Speciality>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<SpecialityResult> result = new List<SpecialityResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.Speciality> entities = new List<Model.Speciality>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public SpecialityResult Find(long id)
        {
            Model.Speciality entity = Dao.Find(id);
            SpecialityResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<SpecialityResult> Find()
        {
            List<Model.Speciality> entities = Dao.Find();

            List<SpecialityResult> results = new List<SpecialityResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, SpecialityParam param)
        {
            Model.Speciality oldEntity = Dao.Find(id);

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

        public void Update(List<SpecialityParam> param)
        {
            //List<UniversityDemo.Speciality> entities = new List<UniversityDemo.Speciality>();

            foreach (var item in param)
            {
                Model.Speciality oldEntity = Dao.Find(item.Id);
                Model.Speciality newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }   
        }
    }
}
