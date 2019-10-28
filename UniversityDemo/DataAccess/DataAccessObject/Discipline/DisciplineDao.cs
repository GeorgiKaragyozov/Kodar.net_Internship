using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Discipline
{
    public class DisciplineDao : IDisciplineDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Discipline entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Discipline entity)
        {
            DisciplineDaoStorage.Disciplines.Remove(entity);
            DisciplineDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Discipline> Find()
        {
            return DisciplineDaoStorage.Disciplines;
        }

        public UniversityDemo.Discipline Find(long id)
        {
            return DisciplineDaoStorage.Disciplines
                 .Where(x => x.Id == id)
                 .Single();
        }

        public UniversityDemo.Discipline Save(UniversityDemo.Discipline entity)
        {
            DisciplineDaoStorage.Disciplines.Add(entity);
            DisciplineDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Discipline> Save(List<UniversityDemo.Discipline> entity)
        {
            entity.ForEach(x => DisciplineDaoStorage.Disciplines.Add(x));

            entity.ForEach(ent => DisciplineDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Discipline Update(UniversityDemo.Discipline entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Discipline> Update(List<UniversityDemo.Discipline> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
