using System;
using UniversityDemo.Business.Processor.UserStatus;

namespace UniversityDemo.Presentation.Service.UserStatus
{
    public class UserStatusService: IUserStatusService
    {
        public UserStatusProcessor Processor { get; set; }
    }
}
