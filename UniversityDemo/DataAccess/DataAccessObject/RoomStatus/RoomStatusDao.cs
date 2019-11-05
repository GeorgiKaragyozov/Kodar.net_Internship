using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public class RoomStatusDao : IRoomStatusDao
    {
        public void Delete(long id)
        {
            Model.RoomStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.RoomStatus entity)
        {
            RoomStatusDaoStorage.Rooms.Remove(entity);
            RoomStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.RoomStatus> Find()
        {
            return RoomStatusDaoStorage.Rooms;
        }

        public Model.RoomStatus Find(long id)
        {
            return RoomStatusDaoStorage.Rooms
               .Where(x => x.Id == id)
               .Single();
        }

        public Model.RoomStatus Save(Model.RoomStatus entity)
        {
            RoomStatusDaoStorage.Rooms.Add(entity);
            RoomStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.RoomStatus> Save(List<Model.RoomStatus> entity)
        {
            entity.ForEach(x => RoomStatusDaoStorage.Rooms.Add(x));

            entity.ForEach(ent => RoomStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.RoomStatus Update(Model.RoomStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.RoomStatus> Update(List<Model.RoomStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
