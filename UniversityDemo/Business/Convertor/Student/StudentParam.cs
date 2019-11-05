using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParam : AccountParam
    {
        public long SpecialityId { get; set; }

        //public long StatusId { get; set; }
    }
}
