using System;

namespace UniversityDemo.Business.Convertor
{
    public class BaseResultNamed : BaseResult
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
