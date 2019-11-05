using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.Business.Convertor.Common
{
    public abstract class BaseResultConverter<TIn, TOut> : IBaseResultConverter<TIn, TOut>
    {      
        public TOut ConvertStandart(TIn param, TOut result)
        {      
            Dictionary<string, object> paramPropDictionary = 
                param.GetType()
                .GetProperties()
                .ToDictionary(p => p.Name, p => p.GetValue(param));

            foreach (var prop in paramPropDictionary)   
            {
                if (result.GetType().GetProperty(prop.Key) != null) 
                {
                    result.GetType().GetProperty(prop.Key).SetValue(result, prop.Value, null);
                }
            }

            //var resultPropDictionary = result.GetType().GetProperties()
            //    .ToDictionary(p => p.Name, p => p.GetValue(result));

            //var paramPropDictionary = param.GetType().GetProperties()
            //    .ToDictionary(p => p.Name, p => p.GetValue(param));

            //foreach (var resultItem in paramPropDictionary)
            //{
            //    if (paramPropDictionary.ContainsKey(resultItem.Key))
            //    {
            //        result.GetType().GetProperty(resultItem.Key).SetValue(
            //            result, paramPropDictionary[resultItem.Key], null);
            //    }
            //}

            return result;
        }

        public abstract TOut ConvertSpecific(TIn param, TOut result);
    }
}
