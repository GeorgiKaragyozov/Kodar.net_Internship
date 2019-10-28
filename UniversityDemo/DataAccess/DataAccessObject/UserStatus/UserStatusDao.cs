using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public class UserStatusDao : IUserStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.UserStatus entity = Find(id);
            Delete(entity); 
        }

        public void Delete(UniversityDemo.UserStatus entity)
        {
            UserStatusDaoStorage.Statuses.Remove(entity);
            UserStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.UserStatus> Find()
        {
            return UserStatusDaoStorage.Statuses;
        }

        public UniversityDemo.UserStatus Find(long id)
        {
            return UserStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public UniversityDemo.UserStatus Save(UniversityDemo.UserStatus entity)
        {
            UserStatusDaoStorage.Statuses.Add(entity);
            UserStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.UserStatus> Save(List<UniversityDemo.UserStatus> entity)
        {
            entity.ForEach(x => UserStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => UserStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.UserStatus Update(UniversityDemo.UserStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.UserStatus> Update(List<UniversityDemo.UserStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
