using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentResult : AccountResult 
    {
        public long SpecialityId { get; set; }
        public string SpecialityName { get; set; }

        //public long StatusId { get; set; }
        //public string StatusName { get; set; }
    }
}
