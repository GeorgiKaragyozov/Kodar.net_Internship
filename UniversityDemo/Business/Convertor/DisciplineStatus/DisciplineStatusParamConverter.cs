using System;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        public DisciplineStatusDao DisciplineStatusDao { get; set; }
    }
}
