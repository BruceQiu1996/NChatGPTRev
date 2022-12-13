namespace NChatGPTRev.Models
{
    public class Profile
    {
        /// <summary>
        /// api token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public string Expires { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public User User { get; set; }
    }

    public class User 
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        public string Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }
    }
}
