    using System;
using System.Collections.Generic;

namespace UniversityDemo
{
    public class Faculty: NamedPersistent
    {
        //private List<Departament> _departaments;

        //public List<Departament> Departaments
        //{
        //    get
        //    {
        //        if(this._departaments == null)
        //        {
        //            throw new NullReferenceException();
        //        }

        //        return this._departaments;
        //    }
        //    set
        //    {
        //        this._departaments = value;
        //    }
        //}

        public Departament Departament { get; set; }

        public FacultyStatus FacultyStatus { get; set; }
    }
}
