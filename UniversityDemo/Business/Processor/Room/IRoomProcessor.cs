using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Room;

namespace UniversityDemo.Business.Processor.Room
{
    public interface IRoomProcessor
    {
        RoomResult Create(RoomParam param);
        List<RoomResult> Create(List<RoomParam> param);

        void Update(long id, RoomParam param);
        void Update(List<RoomParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        RoomResult Find(long id);
        List<RoomResult> Find();
    }
}
