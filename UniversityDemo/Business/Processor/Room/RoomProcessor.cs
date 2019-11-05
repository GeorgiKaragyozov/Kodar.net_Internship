using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Room;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Processor.Room
{
    public class RoomProcessor: IRoomProcessor
    {
        public IRoomDao Dao = new RoomDao();

        public IRoomParamConverter ParamConverter = new RoomParamConverter();

        public IRoomResultConverter ResultConverter = new RoomResultConverter();

        //public RoomProcessor(IRoomDao dao, IRoomParamConverter paramConverter,
        //    IRoomResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public RoomResult Create(RoomParam param)
        {
            Model.Room entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<RoomResult> Create(List<RoomParam> param)
        {
            List<Model.Room> entities = new List<Model.Room>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<RoomResult> result = new List<RoomResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.Room> entities = new List<Model.Room>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public RoomResult Find(long id)
        {
            Model.Room entity = Dao.Find(id);
            RoomResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<RoomResult> Find()
        {
            List<Model.Room> entities = Dao.Find();

            List<RoomResult> results = new List<RoomResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, RoomParam param)
        {
            Model.Room oldEntity = Dao.Find(id);

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

        public void Update(List<RoomParam> param)
        {
            //List<UniversityDemo.Room> entities = new List<UniversityDemo.Room>();

            foreach (var item in param)
            {
                Model.Room oldEntity = Dao.Find(item.Id);
                Model.Room newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
