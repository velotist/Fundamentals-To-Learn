using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UrlAsync
{
    public class UrlAsync
    {
        public async Task<int> GetUrlContentLengthAsync()
        {
            HttpClient client = new HttpClient();

            Task<string> getStringTask =
                client.GetStringAsync("https://docs.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents.Length;
        }

        private void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }
    }
}