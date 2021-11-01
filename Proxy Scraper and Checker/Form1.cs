using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using System.IO;

namespace Proxy_Scraper_and_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Results");
        }

        public string[] proxies;
        public string proxyType;

        string currentTime = DateTime.Now.ToString("dd-MM-yyyy h-mm-ss");

        private void writeToFile(string proxyType, string proxy)
        {
            string fileName = Environment.CurrentDirectory + @"\\Results\\[GOOD] " + proxyType + " Proxies " + currentTime + ".txt";
            File.AppendAllText(fileName, proxy + Environment.NewLine);
        }
               

        private void getProxies(string proxyType)
        {
            string url = "https://api.proxyscrape.com/v2/?request=getproxies&protocol="+proxyType+ "&timeout=10000&country=all&ssl=all&anonymity=all";
            HttpRequest request = new HttpRequest();

            string response = request.Get(url).ToString();

            proxies = response.Split(new[]
            {
                Environment.NewLine
            },
            StringSplitOptions.None
            );

            label_TotalProxy.Text = proxies.Length.ToString();
            
        }

        private void checker(string proxy)
        {
            string testUrl = "https://google.com";

            HttpRequest request = new HttpRequest();

            try
            {
                if (radioButton_Http.Checked)
                {
                    request.Proxy = HttpProxyClient.Parse(proxy);
                    proxyType = "HTTP";
                }
                    

                if (radioButton_Socks4.Checked)
                {
                    request.Proxy = Socks4ProxyClient.Parse(proxy);
                    proxyType = "Socks4";
                }
                    

                if (radioButton_Socks5.Checked)
                {
                    request.Proxy = Socks5ProxyClient.Parse(proxy);
                    proxyType = "Socks5";
                }
                    

                var response = request.Get(testUrl).ToString();
                textBox_Results.Text += proxy + Environment.NewLine;
                label_GoodProxy.Text = (int.Parse(label_GoodProxy.Text) + 1).ToString();

                writeToFile(proxyType, proxy);
            }
            catch(HttpException)
            {
                label_BadProxy.Text = (int.Parse(label_BadProxy.Text) + 1).ToString();
            }
        }

        private void subTask()
        {
            var tasks =
                from proxy in proxies
                select Task.Factory.StartNew(() => checker(proxy));
            Task.WaitAll(tasks.ToArray());
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (radioButton_Http.Checked)
                getProxies("http");

            if (radioButton_Socks4.Checked)
                getProxies("socks4");

            if (radioButton_Socks5.Checked)
                getProxies("socks5");

            Thread thread = new Thread(subTask);
            thread.Start();
            thread.IsBackground = true;

        }
    }
}
