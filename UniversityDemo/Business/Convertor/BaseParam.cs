using System;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor
{
    public abstract class BaseParam
    {
        [SkipProperty]
        public long Id { get; set; }
    }
}
