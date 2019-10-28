using Newtonsoft.Json;

namespace UniversityDemo.Presentation
{
    public class Serialization
    {

        /// <summary>
        /// Serizlize .NET object to a JSON string.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON string</returns>
        public static string Serizlize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        /// <summary>
        /// Deserialize a JSON object to .NET object.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>.NET object</returns>
        public static object Deserialize(string json)
        {
            return JsonConvert.DeserializeObject(json);
        }      
    }
}
