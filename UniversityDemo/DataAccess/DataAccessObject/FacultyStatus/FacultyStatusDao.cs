using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDao : IFacultyStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.FacultyStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.FacultyStatus entity)
        {
            FacultyStatusDaoStorage.FacultiesStatus.Remove(entity);
            FacultyStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.FacultyStatus> Find()
        {
            return FacultyStatusDaoStorage.FacultiesStatus;
        }

        public UniversityDemo.FacultyStatus Find(long id)
        {
            return FacultyStatusDaoStorage.FacultiesStatus
                 .Where(x => x.Id == id)
                 .Single();
        }

        public UniversityDemo.FacultyStatus Save(UniversityDemo.FacultyStatus entity)
        {
            FacultyStatusDaoStorage.FacultiesStatus.Add(entity);
            FacultyStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.FacultyStatus> Save(List<UniversityDemo.FacultyStatus> entity)
        {
            entity.ForEach(x => FacultyStatusDaoStorage.FacultiesStatus.Add(x));

            entity.ForEach(ent => FacultyStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.FacultyStatus Update(UniversityDemo.FacultyStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.FacultyStatus> Update(List<UniversityDemo.FacultyStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
