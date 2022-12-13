using System.Text.Json.Serialization;

namespace NChatGPTRev.Models
{
    public class Conversation
    {
        [JsonPropertyName("action")]
        public string Action => "next";
        [JsonPropertyName("conversation_id")]
        public string Conversation_id { get; set; }
        [JsonPropertyName("model")]
        public string Model => "text-davinci-002-render";
        /// <summary>
        /// 父消息id
        /// 回复某条消息
        /// </summary>
        [JsonPropertyName("parent_message_id")]
        public string Parent_message_id { get; set; }
        [JsonPropertyName("messages")]
        public Message[] Messages { get; set; }
    }

    public class Message 
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// 消息发送者
        /// user=用户
        /// assistant=bot
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; } = "user";
        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonPropertyName("content")]
        public Content Content { get; set; }
    }

    public class Content 
    {
        [JsonPropertyName("content_type")]
        public string Content_type => "text";
        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("parts")]
        public string[] Parts { get; set; }
    }
}
