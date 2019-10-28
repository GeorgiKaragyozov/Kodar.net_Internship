using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Processor.SpecialityStatus
{
    public class SpecialityStatusProcessor: ISpecialityStatusProcessor
    {
        public ISpecialityStatusDao Dao = new SpecialityStatusDao();

        public ISpecialityStatusParamConverter ParamConverter = new SpecialityStatusParamConverter();

        public ISpecialityStatusResultConverter ResultConverter = new SpecialityStatusResultConverter();

        //public SpecialityStatusProcessor(ISpecialityStatusDao dao,
        //    ISpecialityStatusParamConverter paramConverter,
        //    ISpecialityStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public SpecialityStatusResult Create(SpecialityStatusParam param)
        {
            UniversityDemo.SpecialityStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<SpecialityStatusResult> Create(List<SpecialityStatusParam> param)
        {
            List<UniversityDemo.SpecialityStatus> entities = new List<UniversityDemo.SpecialityStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<SpecialityStatusResult> result = new List<SpecialityStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.SpecialityStatus> entities = new List<UniversityDemo.SpecialityStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public SpecialityStatusResult Find(long id)
        {
            UniversityDemo.SpecialityStatus entity = Dao.Find(id);
            SpecialityStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<SpecialityStatusResult> Find()
        {
            List<UniversityDemo.SpecialityStatus> entities = Dao.Find();

            List<SpecialityStatusResult> results = new List<SpecialityStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, SpecialityStatusParam param)
        {
            UniversityDemo.SpecialityStatus oldEntity = Dao.Find(id);

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

        public void Update(List<SpecialityStatusParam> param)
        {
            //List<UniversityDemo.SpecialityStatus> entities = new List<UniversityDemo.SpecialityStatus>();

            foreach (var item in param)
            {
                UniversityDemo.SpecialityStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.SpecialityStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
