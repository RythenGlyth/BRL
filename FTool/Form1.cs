using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection;
using System.Drawing.Text;

namespace FTool
{
    public partial class Form1 : Form
    {
        int panelSlideWidth;
        bool panelSlideHidden;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        public static FontFamily BurbankBigCondensed;
        public static FontFamily CenturyGothic;

        public Form1()
        {
            loadFonts();

            InitializeComponent();
            panelSlideWidth = PanelSlide.Width;
            PanelSlide.Width = 0;
            panelSlideHidden = true;
            itemShop1.BringToFront();

            update();
        }

        public void loadFonts()
        {
            {
                byte[] fontData = Properties.Resources.BurbankBigCondensed_Black;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.BurbankBigCondensed_Black.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.BurbankBigCondensed_Black.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            }
            {
                byte[] fontData = Properties.Resources.CenturyGothic;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.CenturyGothic.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.CenturyGothic.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            }


            BurbankBigCondensed = fonts.Families[0];
            CenturyGothic = fonts.Families[1];
        }

        async public void update()
        {
            var currentVersion = Assembly.GetEntryAssembly().GetName().Version;
            string jsonReponse = await getNewestUpdateResponse();

            dynamic json = JsonConvert.DeserializeObject(jsonReponse);

            var newVersion = new Version(Convert.ToString(json.tag_name));
            if(newVersion > currentVersion)
            {
                DialogResult dialogResult = MessageBox.Show("Update available, \nDo you want to update? \n\nYou have version " + currentVersion.ToString() + " and newest version is " + newVersion.ToString(), "Update available", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    ShowUpdateForm(Convert.ToString(json.assets[0].browser_download_url));


                }
            }

        }

        public static void ShowUpdateForm(string url)
        {
            var updateForm = new DownloadUpdateDialog(url);
            if (updateForm.ShowDialog().Equals(DialogResult.OK))
            {
                Application.Exit();
            }
        }

        async public Task<string> getNewestUpdateResponse()
        {

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("C# App");
            return await httpClient.GetStringAsync("https://api.github.com/repos/RythenGlyth/FTool/releases/latest");
        }

        Point lastPoint;

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                panelSlideHidden = !panelSlideHidden;
            } else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panelSlideHidden)
            {
                PanelSlide.Width += 10;
                if (PanelSlide.Width >= panelSlideWidth)
                {
                    timer1.Stop();
                    panelSlideHidden = false;
                    this.Refresh();
                }
            } else
            {
                PanelSlide.Width -= 10;
                if(PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    panelSlideHidden = true;
                    this.Refresh();
                }
            }
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            panelSlideHidden = false;
            menuButton_Click(sender, e);
            itemShop1.BringToFront();
        }

        private void aesKeyButton_Click(object sender, EventArgs e)
        {
            panelSlideHidden = false;
            menuButton_Click(sender, e);
            aesKeys1.BringToFront();

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            panelSlideHidden = false;
            menuButton_Click(sender, e);
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            panelSlideHidden = false;
            menuButton_Click(sender, e);

        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            panelSlideHidden = false;
            menuButton_Click(sender, e);
            newsPage1.BringToFront();
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            closeTimer.Start();
        }

        int exitInterval = 0;

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            exitInterval += 8;
            if(exitInterval >= 200) Application.Exit();
            Size size = this.ClientSize;
            size.Width = size.Width - exitInterval;
            size.Height = size.Height - exitInterval;
            this.ClientSize = size;
            this.Left = this.Left + exitInterval / 2;
            this.Top = this.Top + exitInterval / 2;
        }
    }
}
