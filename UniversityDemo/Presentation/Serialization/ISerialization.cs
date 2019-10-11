using System;

namespace UniversityDemo.Presentation.Serialization
{
    interface ISerialization<T>
    {
        string Serizlize(T obj);

        T Desialize(string json);
    }
}
