using System;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        public DisciplineStatusDao Dao { get; set; }

        public UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
