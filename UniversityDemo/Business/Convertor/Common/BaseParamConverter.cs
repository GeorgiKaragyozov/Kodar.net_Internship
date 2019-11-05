using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.Business.Convertor.Common
{
    public abstract class BaseParamConverter<TIn, TOut> : IBaseParamConverter<TIn, TOut>
    {           
        public TOut ConvertStandart(TIn param, TOut entity)
        {
            Dictionary<string, object> paramPropDictionary =
              param.GetType()
              .GetProperties()
              .ToDictionary(p => p.Name, p => p.GetValue(param));

            foreach (var prop in paramPropDictionary)
            {
                if (entity.GetType().GetProperty(prop.Key) != null)
                {                   
                    entity.GetType().GetProperty(prop.Key).SetValue(entity, prop.Value, null);
                }
            }

            return entity;
        }

        public abstract TOut ConvertSpecific(TIn param, TOut entity);
    }
}
