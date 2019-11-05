namespace UniversityDemo.Model
{
    public class Departament : NamedPersistent
    {
        public Teacher Teacher { get; set; }

        public Speciality Speciality { get; set; }

        public DepartamentStatus Status { get; set; }
    }
}
