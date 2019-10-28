using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Processor.DisciplineStatus
{
    public class DisciplineStatusProcessor: IDisciplineStatusProcessor
    {
        public IDisciplineStatusDao Dao = new DisciplineStatusDao();

        public IDisciplineStatusParamConverter ParamConverter = new DisciplineStatusParamConverter();

        public IDisciplineStatusResultConverter ResultConverter = new DisciplineStatusResultConverter();

        //public DisciplineStatusProcessor(IDisciplineStatusDao dao, IDisciplineStatusParamConverter paramConverter,
        //    IDisciplineStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public DisciplineStatusResult Create(DisciplineStatusParam param)
        {
            UniversityDemo.DisciplineStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<DisciplineStatusResult> Create(List<DisciplineStatusParam> param)
        {
            List<UniversityDemo.DisciplineStatus> entities = new List<UniversityDemo.DisciplineStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<DisciplineStatusResult> result = new List<DisciplineStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.DisciplineStatus> entities = new List<UniversityDemo.DisciplineStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public DisciplineStatusResult Find(long id)
        {
            UniversityDemo.DisciplineStatus entity = Dao.Find(id);
            DisciplineStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<DisciplineStatusResult> Find()
        {
            List<UniversityDemo.DisciplineStatus> entities = Dao.Find();

            List<DisciplineStatusResult> results = new List<DisciplineStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, DisciplineStatusParam param)
        {
            UniversityDemo.DisciplineStatus oldEntity = Dao.Find(id);

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

        public void Update(List<DisciplineStatusParam> param)
        {
            //List<UniversityDemo.Discipline> entities = new List<UniversityDemo.Discipline>();

            foreach (var item in param)
            {
                UniversityDemo.DisciplineStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.DisciplineStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
