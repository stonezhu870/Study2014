using Newtonsoft.Json;

namespace Model
{
    public class Json
    {
        public static string ToString(object obj, string defaultValue = null)
        {
            return obj == null ? defaultValue : JsonConvert.SerializeObject(obj, new DataRowConverter());
        }

        public static T ToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
