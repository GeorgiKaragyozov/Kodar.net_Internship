using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public class UserStatusDao : IUserStatusDao
    {
        public void Delete(long id)
        {
            Model.UserStatus entity = Find(id);
            Delete(entity); 
        }

        public void Delete(Model.UserStatus entity)
        {
            UserStatusDaoStorage.Statuses.Remove(entity);
            UserStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.UserStatus> Find()
        {
            return UserStatusDaoStorage.Statuses;
        }

        public Model.UserStatus Find(long id)
        {
            return UserStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public Model.UserStatus Save(Model.UserStatus entity)
        {
            UserStatusDaoStorage.Statuses.Add(entity);
            UserStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.UserStatus> Save(List<Model.UserStatus> entity)
        {
            entity.ForEach(x => UserStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => UserStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.UserStatus Update(Model.UserStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.UserStatus> Update(List<Model.UserStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
