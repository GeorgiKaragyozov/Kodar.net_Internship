using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Faculty;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Processor.Faculty
{
    public class FacultyProcessor: IFacultyProcessor
    {
        public IFacultyDao Dao = new FacultyDao();

        public IFacultyParamConverter ParamConverter = new FacultyParamConverter();

        public IFacultyResultConverter ResultConverter = new FacultyResultConverter();

        //public FacultyProcessor(IFacultyDao dao, IFacultyParamConverter paramConverter,
        //    IFacultyResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public FacultyResult Create(FacultyParam param)
        {
            UniversityDemo.Faculty entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<FacultyResult> Create(List<FacultyParam> param)
        {
            List<UniversityDemo.Faculty> entities = new List<UniversityDemo.Faculty>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<FacultyResult> result = new List<FacultyResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.Faculty> entities = new List<UniversityDemo.Faculty>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public FacultyResult Find(long id)
        {
            UniversityDemo.Faculty entity = Dao.Find(id);
            FacultyResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<FacultyResult> Find()
        {
            List<UniversityDemo.Faculty> entities = Dao.Find();

            List<FacultyResult> results = new List<FacultyResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, FacultyParam param)
        {
            UniversityDemo.Faculty oldEntity = Dao.Find(id);

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

        public void Update(List<FacultyParam> param)
        {
            //List<UniversityDemo.Faculty> entities = new List<UniversityDemo.Faculty>();

            foreach (var item in param)
            {
                UniversityDemo.Faculty oldEntity = Dao.Find(item.Id);
                UniversityDemo.Faculty newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
