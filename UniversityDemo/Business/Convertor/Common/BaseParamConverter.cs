using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UniversityDemo.Business.Convertor.Common
{
    public abstract class BaseParamConverter<TSource, TTarget> : IBaseParamConverter<TSource, TTarget>
        where TSource : class , new()
        where TTarget : class, new()
    {
        public TTarget ConvertStandart(TSource param, TTarget entity)
        {
            Dictionary<string, object> paramPropDictionary =
              param.GetType()
              .GetProperties()
              .Where(p => !Attribute.IsDefined(p, typeof(SkipPropertyAttribute)))
              .ToDictionary(p => p.Name, p => p.GetValue(param));

            foreach (var prop in paramPropDictionary)
            {
                if (entity.GetType().GetProperty(prop.Key) != null)
                {
                    entity.GetType().GetProperty(prop.Key).SetValue(entity, prop.Value);
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

            return entity;
        }

        public abstract TTarget ConvertSpecific(TSource param, TTarget entity);
    }
}
