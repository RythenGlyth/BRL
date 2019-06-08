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
    public partial class Form1 : Form
    {
        int panelSlideWidth;
        bool panelSlideHidden;

        public Form1()
        {
            InitializeComponent();
            panelSlideWidth = PanelSlide.Width;
            PanelSlide.Width = 0;
            panelSlideHidden = true;
            itemShop1.BringToFront();
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
            if(panelSlideHidden)
            {
                PanelSlide.Width += 10;
                if(PanelSlide.Width >= panelSlideWidth)
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

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
