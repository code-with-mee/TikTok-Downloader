using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokDownloader
{
    public class ClsVideo
    {
        public string author_avatar { get; set; }
        public string author_id { get; set; }
        public string author_name { get; set; }
        public int comment_count { get; set; }
        public string create_time { get; set; }
        public string id { get; set; }
        public int like_count { get; set; }
        public int share_count { get; set; }
        public bool success { get; set; }
        public string token { get; set; }

        public void Show()
        {
            Console.WriteLine("id : {0},token : {1}",id,token);
        }
    }
}
