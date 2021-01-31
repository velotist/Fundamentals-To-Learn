using System.Diagnostics;

namespace UrlAsync
{
    internal class Program
    {
        // the calling method
        private static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            UrlAsync url = new UrlAsync();
            System.Threading.Tasks.Task<int> content = url.GetUrlContentLengthAsync();
            watch.Stop();
            System.Console.WriteLine(watch.Elapsed.Seconds);
        }
    }
}