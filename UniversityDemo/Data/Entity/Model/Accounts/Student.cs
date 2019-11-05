using Newtonsoft.Json;

namespace UniversityDemo.Model
{
    public class Student: Account
    {
        [JsonIgnore]
        public Model.Speciality Speciality { get; set; }

        //
        [JsonIgnore]
        public StudentStatus Status { get; set; }
    }
}
