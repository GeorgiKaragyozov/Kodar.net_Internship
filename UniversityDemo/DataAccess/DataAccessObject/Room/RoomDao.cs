using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public class RoomDao : IRoomDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Room entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Room entity)
        {
            RoomDaoStorage.Rooms.Remove(entity);
            RoomDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Room> Find()
        {
            return RoomDaoStorage.Rooms;
        }

        public UniversityDemo.Room Find(long id)
        {
            return RoomDaoStorage.Rooms
              .Where(x => x.Id == id)
              .Single();
        }

        public UniversityDemo.Room Save(UniversityDemo.Room entity)
        {
            RoomDaoStorage.Rooms.Add(entity);
            RoomDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Room> Save(List<UniversityDemo.Room> entity)
        {
            entity.ForEach(x => RoomDaoStorage.Rooms.Add(x));

            entity.ForEach(ent => RoomDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Room Update(UniversityDemo.Room entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Room> Update(List<UniversityDemo.Room> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
