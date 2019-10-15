using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        public DisciplineStatusDao DisciplineStatusDao { get; set; }

        public UniversityDemo.DisciplineStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
