using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;

namespace asynchronous
{
    public class HTMLDownloader
    {
        private DateTime start { get; set; }
        private TimeSpan duration { get; set; }

        private void s()
        {
            start = DateTime.Now;
        }

        private void Duration(string function)
        {
            duration = DateTime.Now - start;
            Console.WriteLine("Duration of {1}: {0}", duration, function);
        }

        //synchronous method
        public void DownloadHtml(string url)
        {
            s();
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(
                @"C:\Users\s_zam\Documents\Txt_Files_Csharp\results.html"))
            {
                streamWriter.Write(html);
                //Console.WriteLine("Sync task completed");
            }
            Duration("DownloadHtml");
           // Console.WriteLine("Sync Function Completed");

        }

        public async Task DownloadHtmlAsync(string url)
        {
            s();
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(
                @"C:\Users\s_zam\Documents\Txt_Files_Csharp\results.html"))
            {
                await streamWriter.WriteAsync(html);
                //Console.WriteLine("Async task completed");
            }
            Duration("DownloadHtmlAsync");
            //Console.WriteLine("Async function completed");

        }

        public string GetHtml(string url)
        {
            s();
            var webClient = new WebClient();
            webClient.DownloadString(url);
            Duration("GetHtml");
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            s();
            var webClient = new WebClient();
            await webClient.DownloadStringTaskAsync(url);
            Duration("GetHtmlAsync");
            return await webClient.DownloadStringTaskAsync(url);

        }

    }

}


