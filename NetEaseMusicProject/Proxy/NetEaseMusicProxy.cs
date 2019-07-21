using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


    public class NetEaseMusicProxy
    {
        public async static Task<LoginObject> GetLogin(string phone, string pass)
        {
            return (LoginObject)
                await GetWebObject($"login/cellphone?phone={phone}&password={pass}", typeof(LoginObject));
        }


        private static HttpClient http = new HttpClient();
        private static readonly string httpPrefix = "https://music.aityp.com/";

        private static async Task<object> GetWebObject(string url, Type serializerType)
        {
            url = httpPrefix + url;
            var response = await http.GetAsync(url);
            var serializer = new DataContractJsonSerializer(serializerType);
            var result = await response.Content.ReadAsStringAsync();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = serializer.ReadObject(ms);
            return data;
        }
    }
