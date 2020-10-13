using Newtonsoft.Json;

namespace CoreClassLibrary
{
    public static class MyJsonConvert
    {
        public static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
