using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.RoomStatus;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Processor.RoomStatus
{
    public class RoomStatusProcessor: IRoomStatusProcessor
    {
        public IRoomStatusDao Dao = new RoomStatusDao();

        public IRoomStatusParamConverter ParamConverter = new RoomStatusParamConverter();

        public IRoomStatusResultConverter ResultConverter = new RoomStatusResultConverter();

        //public RoomStatusProcessor(IRoomStatusDao dao, IRoomStatusParamConverter paramConverter,
        //    IRoomStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public RoomStatusResult Create(RoomStatusParam param)
        {
            UniversityDemo.RoomStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<RoomStatusResult> Create(List<RoomStatusParam> param)
        {
            List<UniversityDemo.RoomStatus> entities = new List<UniversityDemo.RoomStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<RoomStatusResult> result = new List<RoomStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.RoomStatus> entities = new List<UniversityDemo.RoomStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public RoomStatusResult Find(long id)
        {
            UniversityDemo.RoomStatus entity = Dao.Find(id);
            RoomStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<RoomStatusResult> Find()
        {
            List<UniversityDemo.RoomStatus> entities = Dao.Find();

            List<RoomStatusResult> results = new List<RoomStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, RoomStatusParam param)
        {
            UniversityDemo.RoomStatus oldEntity = Dao.Find(id);

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

        public void Update(List<RoomStatusParam> param)
        {
            //List<UniversityDemo.RoomStatus> entities = new List<UniversityDemo.RoomStatus>();

            foreach (var item in param)
            {
                UniversityDemo.RoomStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.RoomStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
