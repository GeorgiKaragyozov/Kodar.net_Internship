using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.RoomStatus;
using UniversityDemo.Business.Processor.RoomStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.RoomStatus
{
    public class RoomStatusService: IRoomStatusService
    {
        public RoomStatusProcessor Processor { get; set; }

        public ApiResponse Create(RoomStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<RoomStatusParam> param)
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

        public ApiResponse Update(long id, RoomStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<RoomStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(RoomStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<RoomStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
