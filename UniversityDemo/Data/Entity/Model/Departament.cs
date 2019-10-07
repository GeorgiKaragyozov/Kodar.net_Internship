using System;
using System.Collections.Generic;

namespace UniversityDemo
{
    public class Departament : NamedPersistent
    {
        //private List<Teacher> _teachers;

        //private List<Speciality> specialities;

        //public List<Teacher> Teachers
        //{
        //    get
        //    {
        //        if (this._teachers == null)
        //        {
        //            throw new NullReferenceException();
        //        }

        //        return this._teachers;
        //    }
        //    set
        //    {
        //        this._teachers = value;
        //    }
        //}

        //public List<Speciality> Specialities
        //{
        //    get
        //    {
        //        if (this.specialities == null)
        //        {
        //            throw new NullReferenceException();
        //        }

        //        return this.specialities;
        //    }
        //    set
        //    {
        //        this.specialities = value;
        //    }
        //}

        public Teacher Teacher { get; set; }

        public Speciality Speciality { get; set; }

        public DepartamentStatus DepartamentStatus { get; set; }

        //public Departament(List<Teacher> teachers, List<Speciality> specialities)
        //{
        //    Teachers = teachers;
        //    Specialities = specialities;
        //}
    }
}
