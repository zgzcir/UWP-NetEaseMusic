using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;


public class NetEaseMusicProxy
{
    public async static Task<LoginObject> GetLogin(string phone, string pass)
    {
        return
            await GetWebObject<LoginObject>($"login/cellphone?phone={phone}&password={pass}");
    }


    private static HttpClient http = new HttpClient();
    private static readonly string httpPrefix = "https://music.aityp.com/";

    private static async Task<T> GetWebObject<T>(string url)
    {
        url = httpPrefix + url;
        var response = await http.GetAsync(url);
        var result = await response.Content.ReadAsStringAsync();
        T tObject = JsonConvert.DeserializeObject<T>(result);
        return tObject;
    }
}