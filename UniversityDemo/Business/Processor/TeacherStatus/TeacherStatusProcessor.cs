using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.TeacherStatus
{
    public class TeacherStatusProcessor: ITeacherStatusProcessor
    {
        public ITeacherStatusDao Dao = new TeacherStatusDao();

        public ITeacherStatusParamConverter ParamConverter = new TeacherStatusParamConverter();

        public ITeacherStatusResultConverter ResultConverter = new TeacherStatusResultConverter();

        //public TeacherStatusProcessor(ITeacherStatusDao dao, 
        //    ITeacherStatusParamConverter paramConverter,
        //    ITeacherStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public TeacherStatusResult Create(TeacherStatusParam param)
        {
            Model.Accounts.TeacherStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<TeacherStatusResult> Create(List<TeacherStatusParam> param)
        {
            List<Model.Accounts.TeacherStatus> entities = new List<Model.Accounts.TeacherStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<TeacherStatusResult> result = new List<TeacherStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.Accounts.TeacherStatus> entities = new List<Model.Accounts.TeacherStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public TeacherStatusResult Find(long id)
        {
            Model.Accounts.TeacherStatus entity = Dao.Find(id);
            TeacherStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<TeacherStatusResult> Find()
        {
            List<Model.Accounts.TeacherStatus> entities = Dao.Find();

            List<TeacherStatusResult> results = new List<TeacherStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, TeacherStatusParam param)
        {
            Model.Accounts.TeacherStatus oldEntity = Dao.Find(id);

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

        public void Update(List<TeacherStatusParam> param)
        {
            //List<Model.Accounts.TeacherStatus> entities = new List<Model.Accounts.TeacherStatus>();

            foreach (var item in param)
            {
                Model.Accounts.TeacherStatus oldEntity = Dao.Find(item.Id);
                Model.Accounts.TeacherStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
