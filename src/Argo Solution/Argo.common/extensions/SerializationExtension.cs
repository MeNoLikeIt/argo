using System.Web.Script.Serialization;

namespace Argo.common.extensions
{
    public static class SerializationExtensions
    {
        public static T Deserialize<T>(this string jsonString)
        {
            var serializer = new JavaScriptSerializer();
            if (jsonString.Length > 0)
            {
                serializer.MaxJsonLength = jsonString.Length;
            }
            return serializer.Deserialize<T>(jsonString);
        }
        public static string Serialize<T>(this T source)
        {
            return new JavaScriptSerializer().Serialize(source);
        }
    }
}
