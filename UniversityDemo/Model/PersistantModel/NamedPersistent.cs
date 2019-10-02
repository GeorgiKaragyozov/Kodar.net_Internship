using System;

namespace UniversityDemo
{
    public class NamedPersistent: Persistent
    {
        protected int Code { get; set; }

        protected string Name { get; set; }

        protected string Description { get; set; }

        //public NamedPersistent(int id,int code, string name, string description) 
        //    :base(id)
        //{
        //    Code = code;
        //    Name = name;
        //    Description = description;
        //}
    }
}
