using NChatGPTRev.Models;
using System.Text.Json;

namespace NChatGPTRev
{
    /// <summary>
    /// 机器人
    /// </summary>
    public class Chatbot
    {
        private string _conversationId; //当前会话id
        private string _parentMessageId; //上句话消息id
        private string _chatbotId = Guid.NewGuid().ToString();
        //可以作为隔离不同客户端聊天上下文的凭据，即一个机器人绑定一个客户端
        //客户端编号可以是，微信id,qq id,飞书id,亦或者自己开发的软件的用户id.
        private readonly string _clientID;
        public OpenAISession OpenAISession { get; set; }
        private readonly IDictionary<string, string> Headers = new Dictionary<string, string>();
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        private readonly string _conversation = "https://chat.openai.com/backend-api/conversation"; //聊天接口

        public Chatbot(OpenAISession openAISession, string clientID = null)
        {
            OpenAISession = openAISession;
            _clientID = clientID == null ? Guid.NewGuid().ToString() : clientID;
            ResetConversation();
        }

        /// <summary>
        /// 重置Conversation，开启一个新的会话
        /// </summary>
        public void ResetConversation()
        {
            _conversationId = null;
            _parentMessageId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt">输入</param>
        /// <returns>回复信息</returns>
        public async Task<Reply> GetChatReplyAsync(string prompt)
        {
            var conversation = new Conversation();
            conversation.Conversation_id = _conversationId;
            conversation.Parent_message_id = _parentMessageId;
            conversation.Messages = new Message[]
            {
                new Message()
                {
                    Content = new Content
                    {
                        Parts = new string []{ prompt }
                    }
                }
            };

            return await GetChatResponseAsync(conversation);
        }

        /// <summary>
        /// 获取响应
        /// </summary>
        /// <param name="conversation"></param>
        /// <returns></returns>
        /// <exception cref="Exception">服务器返回非200</exception>
        private async Task<Reply> GetChatResponseAsync(Conversation conversation)
        {
            using (var client = new HttpClient())
            {
                var response = await OpenAISession.PostAsync(_conversation, JsonSerializer.Serialize(conversation, _jsonSerializerOptions));
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Faild to request.StatusCode:{response.StatusCode}");
                }
                var msg = await response.Content.ReadAsStringAsync();
                var data = msg.Split("\n")?.ToList().Where(x => !string.IsNullOrEmpty(x) && !x.Contains("data: [DONE]")).LastOrDefault()?.Substring(5);
                var reply = JsonSerializer.Deserialize<Reply>(data, _jsonSerializerOptions);
                _conversationId = reply.Conversation_id;
                _parentMessageId = reply.Message.Id;

                return reply;
            }
        }
    }
}