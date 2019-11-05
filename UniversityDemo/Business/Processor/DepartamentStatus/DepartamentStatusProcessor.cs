using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DepartamentStatus;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Processor.DepartamentStatus
{
    public class DepartamentStatusProcessor: IDepartamentStatusProcessor
    {
        public IDepartamentStatusDao Dao = new DepartamentStatusDao();

        public IDepartamentStatusParamConverter ParamConverter = new DepartamentStatusParamConverter();

        public IDepartamentStatusResultConverter ResultConverter = new DepartamentStatusResultConverter();

        //public DepartamentStatusProcessor(IDepartamentStatusDao dao, IDepartamentStatusParamConverter paramConverter,
        //    IDepartamentStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public DepartamentStatusResult Create(DepartamentStatusParam param)
        {
            Model.DepartamentStatus departament = ParamConverter.Convert(param, null);

            departament = Dao.Save(departament);

            return ResultConverter.Convert(departament);
        }

        public List<DepartamentStatusResult> Create(List<DepartamentStatusParam> param)
        {
            List<Model.DepartamentStatus> departamentsStatus = new List<Model.DepartamentStatus>();

            foreach (var item in param)
            {
                departamentsStatus.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(departamentsStatus);

            List<DepartamentStatusResult> result = new List<DepartamentStatusResult>();

            departamentsStatus.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.DepartamentStatus> departamentsStatus = new List<Model.DepartamentStatus>();

            foreach (var item in idList)
            {
                departamentsStatus.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public DepartamentStatusResult Find(long id)
        {
            Model.DepartamentStatus entity = Dao.Find(id);
            DepartamentStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<DepartamentStatusResult> Find()
        {
            List<Model.DepartamentStatus> entities = Dao.Find();

            List<DepartamentStatusResult> results = new List<DepartamentStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, DepartamentStatusParam param)
        {
            Model.DepartamentStatus oldEntity = Dao.Find(id);

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

        public void Update(List<DepartamentStatusParam> param)
        {
            //List<UniversityDemo.DepartamentStatus> departamentsStatus = new List<UniversityDemo.DepartamentStatus>();

            foreach (var item in param)
            {
                Model.DepartamentStatus oldEntity = Dao.Find(item.Id);
                Model.DepartamentStatus newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
