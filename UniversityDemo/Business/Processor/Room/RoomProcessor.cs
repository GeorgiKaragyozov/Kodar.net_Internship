﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Room;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Processor.Room
{
    public class RoomProcessor: IRoomProcessor
    {
        public RoomDao RoomDao { get; set; }

        public RoomResult Create(RoomParam param)
        {
            throw new NotImplementedException();
        }

        public List<RoomResult> Create(List<RoomParam> param)
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

        public RoomResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<RoomResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, RoomParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<RoomParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
