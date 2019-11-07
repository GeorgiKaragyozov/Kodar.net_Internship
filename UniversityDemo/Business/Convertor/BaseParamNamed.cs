using System;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor
{
    public class BaseParamNamed: BaseParam
    {
        [SkipProperty]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
