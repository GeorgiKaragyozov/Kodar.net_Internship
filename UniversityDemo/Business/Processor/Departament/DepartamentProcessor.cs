﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Departament;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Processor.Departament
{
    public class DepartamentProcessor: IDepartamentProcessor
    {
        public IDepartamentDao Dao = new DepartamentDao();

        public IDepartamentParamConverter ParamConverter = new DepartamentParamConverter();

        public IDepartamentResultConverter ResultConverter = new DepartamentResultConverter();

        //public DepartamentProcessor(IDepartamentDao dao, IDepartamentParamConverter paramConverter,
        //    IDepartamentResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public DepartamentResult Create(DepartamentParam param)
        {
            Model.Departament entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<DepartamentResult> Create(List<DepartamentParam> param)
        {
            List<Model.Departament> entities = new List<Model.Departament>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<DepartamentResult> result = new List<DepartamentResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.Departament> entities = new List<Model.Departament>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public DepartamentResult Find(long id)
        {
            Model.Departament entity = Dao.Find(id);
            DepartamentResult result = ResultConverter.Convert(entity);

            return result;
        }

        //public List<DepartamentResult> Find(string name)
        //{
        //    List<DepartamentResult> results = new List<DepartamentResult>();

        //    Dao.Find(name.ToLower()).ForEach(account => results.Add(ResultConverter.Convert(account)));

        //    return results;
        //}

        public List<DepartamentResult> Find()
        {
            List<Model.Departament> entities = Dao.Find();

            List<DepartamentResult > results = new List<DepartamentResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, DepartamentParam param)
        {
            Model.Departament oldEntity = Dao.Find(id);

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

        public void Update(List<DepartamentParam> param)
        {
            //List<UniversityDemo.Departament> entities = new List<UniversityDemo.Departament>();

            foreach (var item in param)
            {
                Model.Departament oldEntity = Dao.Find(item.Id);
                Model.Departament newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
