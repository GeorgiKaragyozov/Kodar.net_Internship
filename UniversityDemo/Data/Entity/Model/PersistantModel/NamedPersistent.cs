using System;

namespace UniversityDemo
{
    public abstract class NamedPersistent: Persistent
    {
        protected int Code { get; set; }

        protected string Name { get; set; }

        protected string Description { get; set; }
    }
}
