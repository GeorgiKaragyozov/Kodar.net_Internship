using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Room;
using UniversityDemo.Business.Processor.Room;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Room
{
    public class RoomService: IRoomService
    {
        public RoomProcessor Processor { get; set; }

        public ApiResponse Create(RoomParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<RoomParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPk(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, RoomParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<RoomParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(RoomParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<RoomParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
