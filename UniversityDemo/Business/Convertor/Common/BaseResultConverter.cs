using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.Business.Convertor.Common
{
    public abstract class BaseResultConverter<TSource, TTarget> : IBaseResultConverter<TSource, TTarget>
        where TSource : class, new()
        where TTarget : class, new()
    {      
        public TTarget ConvertStandart(TSource param, TTarget result)
        {      
            Dictionary<string, object> paramPropDictionary = 
                param.GetType()
                .GetProperties()
                .ToDictionary(p => p.Name, p => p.GetValue(param));

            foreach (var prop in paramPropDictionary)   
            {
                if (result.GetType().GetProperty(prop.Key) != null) 
                {
                    result.GetType().GetProperty(prop.Key).SetValue(result, prop.Value);
                }
            }

            return result;
        }

        public abstract TTarget ConvertSpecific(TSource param, TTarget result);
    }
}
