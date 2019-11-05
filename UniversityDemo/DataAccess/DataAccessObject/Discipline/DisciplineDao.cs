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
            Model.Discipline entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Discipline entity)
        {
            DisciplineDaoStorage.Disciplines.Remove(entity);
            DisciplineDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Discipline> Find()
        {
            return DisciplineDaoStorage.Disciplines;
        }

        public Model.Discipline Find(long id)
        {
            return DisciplineDaoStorage.Disciplines
                 .Where(x => x.Id == id)
                 .Single();
        }

        public Model.Discipline Save(Model.Discipline entity)
        {
            DisciplineDaoStorage.Disciplines.Add(entity);
            DisciplineDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Discipline> Save(List<Model.Discipline> entity)
        {
            entity.ForEach(x => DisciplineDaoStorage.Disciplines.Add(x));

            entity.ForEach(ent => DisciplineDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Discipline Update(Model.Discipline entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Discipline> Update(List<Model.Discipline> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
