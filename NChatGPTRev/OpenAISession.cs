using NChatGPTRev.Extensions;
using NChatGPTRev.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NChatGPTRev
{
    /// <summary>
    /// OpenAPi会话
    /// </summary>
    public class OpenAISession
    {
        /// <summary>
        /// request header:UserAgent
        /// </summary>
        public string UserAgent { get; private set; }
        /// <summary>
        /// cookie:CfClearance
        /// </summary>
        public string CfClearance { get; private set; }
        /// <summary>
        /// cookie:Session_token
        /// </summary>
        public string Session_token { get; private set; }
        public string AccessToken 
        { 
            get; 
            private set;
        }
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
        internal IDictionary<string, string> Headers { get; set; }
        internal IDictionary<string, string> Cookies { get; set; }
        internal IDictionary<string, string> Proxies { get; set; }

        public OpenAISession(string session_token,string cfClearance,string userAgent)
        {
            Session_token = session_token;
            CfClearance = cfClearance;
            UserAgent = userAgent;
            Headers = new Dictionary<string, string>();
            Cookies = new Dictionary<string, string>();
            Proxies = new Dictionary<string, string>();
        }

        /// <summary>
        /// 刷新token
        /// access token和sessionToken
        /// 建议定时刷新保持登陆状态
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task RefreshSessionAsync()
        {
            if (string.IsNullOrEmpty(Session_token))
            {
                throw new Exception("No tokens provided");
            }

            // Set cookies
            Cookies.Put("__Secure-next-auth.session-token", Session_token);
            Cookies.Put("cf_clearance", CfClearance);
            string cookiesString = GetCookiesString();
            Dictionary<string, string> map = new Dictionary<string, string>();
            Headers.Put("User-Agent", UserAgent);
            Headers.Put("cookie", cookiesString);
            Headers.Put("Cookie", cookiesString);

            var response = await GetAsync("https://chat.openai.com/api/auth/session");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("err code: " + response.StatusCode);
                Console.WriteLine("cf_clearance: " + CfClearance);
                Console.WriteLine("token: " + Session_token);
                Console.WriteLine("userAgent: " + UserAgent);
                Console.WriteLine("请检查以上参数是否正确，是否过期。");

                throw new Exception("无法获取token!请重试");
            }

            try
            {
                string name = "__Secure-next-auth.session-token=";
                var cookies = response.Headers.GetValues("Set-Cookie");
                var stoken = cookies.FirstOrDefault(x => x.StartsWith(name));
                Session_token = stoken == null ? Session_token : stoken.Substring(name.Length, stoken.IndexOf(";") - name.Length);
                Cookies.Put("__Secure-next-auth.session-token", Session_token);
                var result = await response.Content.ReadAsStringAsync();
                AccessToken = JsonSerializer.Deserialize<Profile>(result, _jsonSerializerOptions)?.AccessToken;
                RefreshHeaders();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {nameof(RefreshSessionAsync)}:{ex}");
                throw new Exception($"Error {nameof(RefreshSessionAsync)}", ex);
            }
        }

        private void RefreshHeaders()
        {
            Headers.Put("Host", "chat.openai.com");
            Headers.Put("Accept", "text/event-stream");
            Headers.Put("Authorization", $"Bearer {AccessToken}");
            Headers.Put("User-Agent", UserAgent);
            Headers.Put("X-Openai-Assistant-App-Id", string.Empty);
            Headers.Put("Connection", "close");
            Headers.Put("Accept-Language", "en-US,en;q=0.9");
            Headers.Put("Referer", "https://chat.openai.com/chat");
        }

        /// <summary>
        /// 获取cookies字符串
        /// </summary>
        /// <returns></returns>
        public string GetCookiesString()
        {
            string result = null;
            StringBuilder sb = new StringBuilder();
            foreach (var item in Cookies)
            {
                string key = item.Key;
                string value = item.Value;
                sb.Append($"{key}={value}; ");
            }
            result = sb.ToString();
            Headers.Put("cookie", result);

            return result;
        }

        internal async Task<HttpResponseMessage> PostAsync(string url, string data)
        {
            Cookies.Put("__Secure-next-auth.session-token", Session_token);
            Cookies.Put("__Secure-next-auth.callback-url", "https://chat.openai.com/");
            Cookies.Put("cf_clearance", CfClearance);
            GetCookiesString();
            using (var client = new HttpClient())
            {
                var content = new StringContent(data);
                foreach (var header in Headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return await client.PostAsync(url, content);
            }
        }

        internal async Task<HttpResponseMessage> GetAsync(string url)
        {
            GetCookiesString();
            using (var handler = new HttpClientHandler() { UseCookies = true })
            using (var client = new HttpClient())
            {
                foreach (var header in Headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                return await client.GetAsync(url);
            }
        }
    }
}
