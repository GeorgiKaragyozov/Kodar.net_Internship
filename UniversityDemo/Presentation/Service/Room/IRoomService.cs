using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Room;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Room
{
    public interface IRoomService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(RoomParam param);
        ApiResponse Create(List<RoomParam> param);

        ApiResponse Update(long id, RoomParam param);
        ApiResponse Update(List<RoomParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(RoomParam param);
        void ValidateParameters(List<RoomParam> param);
    }
}
