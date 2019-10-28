using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Model;

namespace UniversityDemo.DataAccess.DataAccessObject.Lecture
{
    public class LectureDao : ILectureDao
    {
        public void Delete(long id)
        {
            Model.Lecture entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Lecture entity)
        {
            LectureDaoStorage.Lectures.Remove(entity);
            LectureDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Lecture> Find()
        {
            return LectureDaoStorage.Lectures;
        }

        public Model.Lecture Find(long id)
        {
            return LectureDaoStorage.Lectures
              .Where(x => x.Id == id)
              .Single(); 
        }

        public Model.Lecture Save(Model.Lecture entity)
        {
            LectureDaoStorage.Lectures.Add(entity);
            LectureDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Lecture> Save(List<Model.Lecture> entity)
        {
            entity.ForEach(x => LectureDaoStorage.Lectures.Add(x));

            entity.ForEach(ent => LectureDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Lecture Update(Model.Lecture entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Lecture> Update(List<Model.Lecture> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
