using System.Collections.Generic;
using UniversityDemo.Business.Convertor.RoomStatus;

namespace UniversityDemo.Business.Processor.RoomStatus
{
    public interface IRoomStatusProcessor
    {
        RoomStatusResult Create(RoomStatusParam param);
        List<RoomStatusResult> Create(List<RoomStatusParam> param);

        void Update(long id, RoomStatusParam param);
        void Update(List<RoomStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        RoomStatusResult Find(long id);
        List<RoomStatusResult> Find();
    }
}
