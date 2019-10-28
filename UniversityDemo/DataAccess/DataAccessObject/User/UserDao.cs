using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public class UserDao : IUserDao
    {
        public void Delete(long id)
        {
            UniversityDemo.User entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.User entity)
        {
            UserDaoStorage.Users.Remove(entity);
            UserDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.User> Find()
        {
            return UserDaoStorage.Users;
        }

        public UniversityDemo.User Find(long id)
        {
            return UserDaoStorage.Users
             .Where(x => x.Id == id)
             .Single();
        }

        public UniversityDemo.User Save(UniversityDemo.User entity)
        {
            UserDaoStorage.Users.Add(entity);
            UserDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.User> Save(List<UniversityDemo.User> entity)
        {
            entity.ForEach(x => UserDaoStorage.Users.Add(x));

            entity.ForEach(ent => UserDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;  
        }

        public UniversityDemo.User Update(UniversityDemo.User entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.User> Update(List<UniversityDemo.User> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
