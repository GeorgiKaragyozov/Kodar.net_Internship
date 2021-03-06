﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Processor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusProcessor: ITeacherDisciplineStatusProcessor
    {
        public ITeacherDisciplineStatusDao Dao = new TeacherDisciplineStatusDao();

        public ITeacherDisciplineStatusParamConverter ParamConverter = new TeacherDisciplineStatusParamConverter();

        public ITeacherDisciplineStatusResultConverter ResultConverter = new TeacherDisciplineStatusResultConverter();

        //public TeacherDisciplineStatusProcessor(ITeacherDisciplineStatusDao dao,
        //    ITeacherDisciplineStatusParamConverter paramConverter,
        //    ITeacherDisciplineStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public TeacherDisciplineStatusResult Create(TeacherDisciplineStatusParam param)
        {
            Model.TeacherDisciplineStatus entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<TeacherDisciplineStatusResult> Create(List<TeacherDisciplineStatusParam> param)
        {
            List<Model.TeacherDisciplineStatus> entities = 
                new List<Model.TeacherDisciplineStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<TeacherDisciplineStatusResult> result = new List<TeacherDisciplineStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.TeacherDisciplineStatus> entities =
                new List<Model.TeacherDisciplineStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public TeacherDisciplineStatusResult Find(long id)
        {
            Model.TeacherDisciplineStatus entity = Dao.Find(id);
            TeacherDisciplineStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<TeacherDisciplineStatusResult> Find()
        {
            List<Model.TeacherDisciplineStatus> entities = Dao.Find();

            List<TeacherDisciplineStatusResult> results = new List<TeacherDisciplineStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, TeacherDisciplineStatusParam param)
        {
            Model.TeacherDisciplineStatus oldEntity = Dao.Find(id);

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

        public void Update(List<TeacherDisciplineStatusParam> param)
        {
            //List<Data.Entity.Model.Status.TeacherDisciplineStatus> entities =
            //new List<Data.Entity.Model.Status.TeacherDisciplineStatus>();

            foreach (var item in param)
            {
                Model.TeacherDisciplineStatus ldEntity = Dao.Find(item.Id);
                Model.TeacherDisciplineStatus newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
