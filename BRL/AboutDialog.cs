using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRL
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void rythenglyth_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/rythenglyth");
        }

        private void brleaks_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/BRLeaks_");
        }

        private void rythenglyth_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/rythenglyth");
        }

        private void brleaks_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/kStqmd");
        }

        private void rythenglyth_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC5rt0GnSstKio9NGxPsRFnw");
        }

        private void brleaks_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_efo0vMP31b3ave84-O5ZQ");
        }

        private void brleaks_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/itsbrleaks_");
        }

        private void support_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/x5yxGbr");
        }
    }
}
