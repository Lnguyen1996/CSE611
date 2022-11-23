namespace TimeSideCache.Data
{
    public class CacheData
    {
        public int Id { get; set; }
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";
        public DateTime CacheDateTime { get; set; }
        public TimeSpan CacheLifeTime { get; set; }
    }
}
