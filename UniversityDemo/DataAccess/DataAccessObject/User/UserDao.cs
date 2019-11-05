using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public class UserDao : IUserDao
    {
        public void Delete(long id)
        {
            Model.User entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.User entity)
        {
            UserDaoStorage.Users.Remove(entity);
            UserDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.User> Find()
        {
            return UserDaoStorage.Users;
        }

        public Model.User Find(long id)
        {
            return UserDaoStorage.Users
             .Where(x => x.Id.Equals(id))
             .Single();
        }

        public Model.User Save(Model.User entity)
        {
            UserDaoStorage.Users.Add(entity);
            UserDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.User> Save(List<Model.User> entity)
        {
            entity.ForEach(x => UserDaoStorage.Users.Add(x));

            entity.ForEach(ent => UserDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;  
        }

        public Model.User Update(Model.User entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.User> Update(List<Model.User> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
