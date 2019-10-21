using System;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public class DisciplineStatusParamConverter: IDisciplineStatusParamConverter
    {
        public IDisciplineStatusDao Dao { get; set; }

        public DisciplineStatusParamConverter(IDisciplineStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
