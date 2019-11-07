using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public interface ISpecialityResultConverter
    {
        SpecialityResult Convert(Model.Speciality param);
    }
}
