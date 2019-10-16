using System;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        public DisciplineDao Dao { get; set; }

        public UniversityDemo.Discipline Convert(DisciplineParam param)
        {
            throw new NotImplementedException();
        }
    }
}
