using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace CoreClassLibrary
{
    public static class MyJsonConvert
    {
        [return: MaybeNull]
        public static T DeserializeObject<T>(string json) where T: notnull
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
