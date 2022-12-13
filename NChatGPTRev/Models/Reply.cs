namespace NChatGPTRev.Models
{
    public class Reply
    {
        /// <summary>
        /// 回复消息
        /// </summary>
        public Message Message { get; set; }
        /// <summary>
        /// 所属谈话id
        /// </summary>
        public string Conversation_id { get; set; }
    }
}
