using Client.Models;

namespace Client
{
    public static class StaticStore
    {
        public static string Token { get; set; }
        public static IMemoAPI memoApi { get; set; }
    }
}