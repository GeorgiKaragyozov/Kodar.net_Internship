using System;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        public DisciplineDao DisciplineDao { get; set; }
    }
}
