using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace downloadManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> urls = new List<String>
            {
                "https://learn.microsoft.com/en-us/dotnet/api/system.threading.semaphore?view=net-8.0",
                "https://martinfowler.com/articles/continuousIntegration.html"

            };
            DownloadManager downloadManager = new DownloadManager();
            foreach (var url in urls)
            {
                downloadManager.AddLink(url);
            }
            downloadManager.StartQueue();
            Console.WriteLine("Press any ket to exit");
            Console.ReadKey();
        }
    }
}
class DownloadManager
{
    private List<String> queue = new List<String>();
    private List<Task> tasks = new List<Task>();
    public void AddLink(String url)
    {
        queue.Add(url);
    }
    public void StartQueue()
    {
        foreach (var url in queue)
        {
            var task = Task.Run(() => download(url));
            tasks.Add(task);
        }
        Task.WaitAll(tasks.ToArray());
        Console.WriteLine("Successful");

    }
    private void download(String url)
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                Uri uri = new Uri(url);
                String fileName = Path.GetFileName(uri.LocalPath);
                client.DownloadFile(url, fileName);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
