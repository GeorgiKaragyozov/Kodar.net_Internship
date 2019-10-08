using System;
using UniversityDemo.Business.Processor.User;

namespace UniversityDemo.Presentation.Service.User
{
    public class UserService: IUserService
    {
        public UserProcessor UserProcessor { get; set; }
    }
}
