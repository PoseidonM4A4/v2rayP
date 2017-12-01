using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v2rayP.Resources.Localization;

namespace v2rayP.Util
{
    public class JSON
    {
        static DefaultContractResolver resolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };
        static JsonSerializerSettings settings = new JsonSerializerSettings{
                ContractResolver = resolver,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
        };

        public static string Serialize(object obj) => JsonConvert.SerializeObject(obj, settings);

        public static bool Write(string path, object obj)
        {
            var json = Serialize(obj);
            try
            {
                File.WriteAllText(path, json, new System.Text.UTF8Encoding(false));
                return true;
            }
            catch (Exception ex)
            {
                Logging.Error(String.Format(I18n.MsgFailToWriteJSON, path, ex));
                return false;
            }
            
        }

        public static T Read<T>(string path)
        {
            var json = File.ReadAllText(path, new System.Text.UTF8Encoding(false));
            return json == null ? default(T) : JsonConvert.DeserializeObject<T>(json);
        }
    }
}
