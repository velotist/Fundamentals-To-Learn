using System.Diagnostics;

namespace UrlAsync
{
    class Program
    {
        // the calling method
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            var url = new UrlAsync();
            System.Threading.Tasks.Task<int> content = url.GetUrlContentLengthAsync();
            watch.Stop();
            System.Console.WriteLine(watch.Elapsed.Seconds);
        }
    }
}