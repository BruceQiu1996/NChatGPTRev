namespace NChatGPTRev.Extensions
{
    public static class CollectionExtension
    {
        /// <summary>
        /// 字典插入,key存在的话就更新值
        /// </summary>
        /// <typeparam name="Key"></typeparam>
        /// <typeparam name="Value"></typeparam>
        /// <param name="source"></param>
        /// <param name="item"></param>
        public static void Put<Key, Value>(this IDictionary<Key, Value> source, Key key, Value value)
        {
            if (source.ContainsKey(key))
            {
                source[key] = value;
            }
            else
            {
                source.Add(key, value);
            }
        }
    }
}
