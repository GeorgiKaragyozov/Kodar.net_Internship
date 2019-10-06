using System;

namespace UniversityDemo
{
    public class NamedPersistent: Persistent
    {
        protected int Code { get; set; }

        protected string Name { get; set; }

        protected string Description { get; set; }
    }
}
