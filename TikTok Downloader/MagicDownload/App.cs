using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Leaf.xNet;
using Newtonsoft.Json;

namespace MagicDownload
{
    public class App
    {
        public void Start()
        {
            string downloadUrl = "https://www.tiktok.com/@bartlettmelissa/video/7240972332238425350";
            string currAPI = "https://api.tikmate.app/api/lookup";

            HttpRequest request = new HttpRequest();
            request.AllowAutoRedirect = false;
            request.Proxy = null;
            request.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36");
            string[] textArray1 = new string[] { "url=", downloadUrl };
            string str = string.Concat(textArray1);

            try
            {
                HttpResponse response = request.Post(currAPI, str, "application/x-www-form-urlencoded; charset=UTF-8");
                if(response != null)
                {
                    ClsVideo video = JsonConvert.DeserializeObject<ClsVideo>(response.ToString());
                    if(video != null)
                    {
                        String[] combines = new string[] { "https://tikmate.app/download/", video.token, "/", video.id, ".mp4?hd=1" };
                        String generateDownloadLink = string.Concat(combines);
                        Console.WriteLine("link => " + generateDownloadLink);
                        WebClient webClient = new WebClient();

                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                        webClient.DownloadFileAsync(new Uri(generateDownloadLink), "./videos/" + video.id + ".mp4");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.Message);
            }
        }

        private void ProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download completed!");
        }
    }
}
