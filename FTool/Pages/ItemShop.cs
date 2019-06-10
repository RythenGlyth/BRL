using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace FTool.Pages
{
    public partial class ItemShop : UserControl
    {
        public ItemShop()
        {
            InitializeComponent();
        }

        private void ItemShop_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(loadShop);
            thread1.Start();


            this.Title.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 24);
            this.featured_label.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 18);
            this.daily_label.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 18);
            this.label1.Font = new System.Drawing.Font(Form1.CenturyGothic, 16);

        }

        async void loadShop()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync("https://fortnite-api.theapinetwork.com/store/get?authorization=12f489664e58b6608a81c4d446bb9822");
                dynamic json = JsonConvert.DeserializeObject(response);

                foreach (dynamic item in json.data)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(item["item"]["images"]["information"].ToString());
                    pictureBox.Width = (featuredShop.Width - 30) / 3;
                    pictureBox.Height = (featuredShop.Width - 30) / 3;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    if ((bool)item.store.isFeatured)
                    {
                        MethodInvoker methodInvokerDelegate = delegate () { this.featuredShop.Controls.Add(pictureBox); };
                        if (this.InvokeRequired)
                            this.Invoke(methodInvokerDelegate);
                        else
                            methodInvokerDelegate();
                        //System.Windows.Forms.Control.Invoke(addToFeaturedDelegate, new Object[] { pictureBox });
                    }
                    else
                    {
                        MethodInvoker methodInvokerDelegate = delegate () { this.dailyShop.Controls.Add(pictureBox); };
                        if (this.InvokeRequired)
                            this.Invoke(methodInvokerDelegate);
                        else
                            methodInvokerDelegate();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
