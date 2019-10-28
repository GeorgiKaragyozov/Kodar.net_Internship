using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.FacultyStatus;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Processor.FacultyStatus
{
    public class FacultyStatusProcessor: IFacultyStatusProcessor
    {
        public IFacultyStatusDao Dao = new FacultyStatusDao();

        public IFacultyStatusParamConverter ParamConverter = new FacultyStatusParamConverter();

        public IFacultyStatusResultConverter ResultConverter = new FacultyStatusResultConverter();

        //public FacultyStatusProcessor(IFacultyStatusDao dao, IFacultyStatusParamConverter paramConverter,
        //    IFacultyStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public FacultyStatusResult Create(FacultyStatusParam param)
        {
            UniversityDemo.FacultyStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<FacultyStatusResult> Create(List<FacultyStatusParam> param)
        {
            List<UniversityDemo.FacultyStatus> entities = new List<UniversityDemo.FacultyStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<FacultyStatusResult> result = new List<FacultyStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.FacultyStatus> entities = new List<UniversityDemo.FacultyStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public FacultyStatusResult Find(long id)
        {
            UniversityDemo.FacultyStatus entity = Dao.Find(id);
            FacultyStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<FacultyStatusResult> Find()
        {
            List<UniversityDemo.FacultyStatus> entities = Dao.Find();

            List<FacultyStatusResult> results = new List<FacultyStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, FacultyStatusParam param)
        {
            UniversityDemo.FacultyStatus oldEntity = Dao.Find(id);

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

        public void Update(List<FacultyStatusParam> param)
        {
            //List<UniversityDemo.FacultyStatus> entities = new List<UniversityDemo.FacultyStatus>();

            foreach (var item in param)
            {
                UniversityDemo.FacultyStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.FacultyStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
