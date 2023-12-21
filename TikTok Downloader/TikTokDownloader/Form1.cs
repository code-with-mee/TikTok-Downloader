using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTokDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //int start = 1;
            //foreach (string link in txtLinks.Lines)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
                    DownloadProgress pd = new DownloadProgress(txtLinks.Lines,0);
                    pd.Show();
            //    });
            //    start++;
            //}
        }
    }
}
