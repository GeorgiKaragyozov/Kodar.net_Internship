using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public class RoomDao : IRoomDao
    {
        public void Delete(long id)
        {
            Model.Room entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Room entity)
        {
            RoomDaoStorage.Rooms.Remove(entity);
            RoomDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Room> Find()
        {
            return RoomDaoStorage.Rooms;
        }

        public Model.Room Find(long id)
        {
            return RoomDaoStorage.Rooms
              .Where(x => x.Id == id)
              .Single();
        }

        public Model.Room Save(Model.Room entity)
        {
            RoomDaoStorage.Rooms.Add(entity);
            RoomDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Room> Save(List<Model.Room> entity)
        {
            entity.ForEach(x => RoomDaoStorage.Rooms.Add(x));

            entity.ForEach(ent => RoomDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Room Update(Model.Room entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Room> Update(List<Model.Room> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
