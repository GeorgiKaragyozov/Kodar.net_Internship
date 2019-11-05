namespace UniversityDemo.Business.Convertor.Common
{
    interface IBaseParamConverter<TIn, TOut>
    {
        TOut ConvertStandart(TIn param, TOut entity);

        TOut ConvertSpecific(TIn param, TOut entity);
    }
}
