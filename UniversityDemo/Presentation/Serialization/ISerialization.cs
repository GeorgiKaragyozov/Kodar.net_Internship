using System;

namespace UniversityDemo.Presentation.Serialization
{
    public interface ISerialization<T>
    {
        string Serizlize(T obj);

        T Deserialize(string json);
    }
}
