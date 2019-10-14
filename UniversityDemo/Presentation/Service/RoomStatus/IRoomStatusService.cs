using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.RoomStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.RoomStatus
{
    public interface IRoomStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(RoomStatusParam param);
        ApiResponse Create(List<RoomStatusParam> param);

        ApiResponse Update(long id, RoomStatusParam param);
        ApiResponse Update(List<RoomStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(RoomStatusParam param);
        void ValidateParameters(List<RoomStatusParam> param);
    }
}
