using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public class RoomStatusDao : IRoomStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.RoomStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.RoomStatus entity)
        {
            RoomStatusDaoStorage.Rooms.Remove(entity);
            RoomStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.RoomStatus> Find()
        {
            return RoomStatusDaoStorage.Rooms;
        }

        public UniversityDemo.RoomStatus Find(long id)
        {
            return RoomStatusDaoStorage.Rooms
               .Where(x => x.Id == id)
               .Single();
        }

        public UniversityDemo.RoomStatus Save(UniversityDemo.RoomStatus entity)
        {
            RoomStatusDaoStorage.Rooms.Add(entity);
            RoomStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.RoomStatus> Save(List<UniversityDemo.RoomStatus> entity)
        {
            entity.ForEach(x => RoomStatusDaoStorage.Rooms.Add(x));

            entity.ForEach(ent => RoomStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.RoomStatus Update(UniversityDemo.RoomStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.RoomStatus> Update(List<UniversityDemo.RoomStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
