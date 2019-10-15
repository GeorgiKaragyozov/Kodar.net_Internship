using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public class DisciplineParamConverter: IDisciplineParamConverter
    {
        public DisciplineDao DisciplineDao { get; set; }

        public UniversityDemo.Discipline Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
