using System;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        public IDisciplineDao Dao { get; set; }

        public DisciplineParamConverter(IDisciplineDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Discipline Convert(DisciplineParam param)
        {
            throw new NotImplementedException();
        }
    }
}
