using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace UniversityDemo.Presentation.Serialization
{
    public class Serialization<T>: ISerialization<T>
    {

        /// <summary>
        /// Converts an Object to Json Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Json object</returns>
        public string Serizlize(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Converts a Json Object to Object
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Object</returns>
        public T Desialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }      
    }
}
