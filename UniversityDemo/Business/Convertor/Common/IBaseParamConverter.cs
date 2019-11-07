namespace UniversityDemo.Business.Convertor.Common
{
    public interface IBaseParamConverter<TSource, TTarget>
        where TSource : class, new()
        where TTarget : class, new()
    {
        TTarget ConvertStandart(TSource param, TTarget entity);

        TTarget ConvertSpecific(TSource param, TTarget entity);
    }
}
