using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDao : IFacultyStatusDao
    {
        public void Delete(long id)
        {
            Model.FacultyStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.FacultyStatus entity)
        {
            FacultyStatusDaoStorage.FacultiesStatus.Remove(entity);
            FacultyStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.FacultyStatus> Find()
        {
            return FacultyStatusDaoStorage.FacultiesStatus;
        }

        public Model.FacultyStatus Find(long id)
        {
            return FacultyStatusDaoStorage.FacultiesStatus
                 .Where(x => x.Id == id)
                 .Single();
        }

        public Model.FacultyStatus Save(Model.FacultyStatus entity)
        {
            FacultyStatusDaoStorage.FacultiesStatus.Add(entity);
            FacultyStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.FacultyStatus> Save(List<Model.FacultyStatus> entity)
        {
            entity.ForEach(x => FacultyStatusDaoStorage.FacultiesStatus.Add(x));

            entity.ForEach(ent => FacultyStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.FacultyStatus Update(Model.FacultyStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.FacultyStatus> Update(List<Model.FacultyStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
