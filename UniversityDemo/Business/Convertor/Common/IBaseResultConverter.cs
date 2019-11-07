namespace UniversityDemo.Business.Convertor.Common
{
    public interface IBaseResultConverter<TSource, TTarget>
        where TSource : class, new()
        where TTarget : class, new()
    {
        TTarget ConvertStandart(TSource param, TTarget result);

        TTarget ConvertSpecific(TSource param, TTarget result);
    }
}
