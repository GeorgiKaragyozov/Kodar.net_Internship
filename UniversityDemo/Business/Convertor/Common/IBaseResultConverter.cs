namespace UniversityDemo.Business.Convertor.Common
{
    interface IBaseResultConverter<TIn, TOut>
    {
        TOut ConvertStandart(TIn param, TOut result);

        TOut ConvertSpecific(TIn param, TOut result);
    }
}
