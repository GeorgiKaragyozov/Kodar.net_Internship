namespace UniversityDemo.Model
{
    public class Faculty: NamedPersistent
    {
        public Model.Departament Departament { get; set; }

        public FacultyStatus Status { get; set; }
    }
}
