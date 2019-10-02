using System;
using System.Collections.Generic;

namespace UniversityDemo
{
    public class Discipline: NamedPersistent
    {
        private List<Discipline> _disciplines;

        public List<Discipline> Disciplines
        {
            get
            {
                if(this._disciplines == null)
                {
                    throw new NullReferenceException();
                }

                return this._disciplines;
            }
            set
            {
                this._disciplines = value;
            }
        }
    }
}
