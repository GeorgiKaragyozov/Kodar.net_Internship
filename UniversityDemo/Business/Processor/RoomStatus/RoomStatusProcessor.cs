using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.RoomStatus;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Processor.RoomStatus
{
    public class RoomStatusProcessor: IRoomStatusProcessor
    {
        public IRoomStatusDao Dao { get; set; }

        public IRoomStatusParamConverter ParamConverter { get; set; }

        public IRoomStatusResultConverter ResultConverter { get; set; }

        public RoomStatusProcessor(IRoomStatusDao dao, IRoomStatusParamConverter paramConverter,
            IRoomStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public RoomStatusResult Create(RoomStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<RoomStatusResult> Create(List<RoomStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public RoomStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<RoomStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, RoomStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<RoomStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
