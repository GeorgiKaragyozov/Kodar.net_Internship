﻿using System;

namespace UniversityDemo
{
    public abstract class NamedPersistent: Persistent
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
