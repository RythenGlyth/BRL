using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace BRL.Pages
{
    public partial class AesKeys : UserControl
    {
        public AesKeys()
        {
            InitializeComponent();
        }

        private void AesKeys_Load(object sender, EventArgs e)
        {
            setAesKeys();
        }

        async private void setAesKeys()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpResponseMessage response = await httpClient.GetAsync("http://benbotfn.tk:8080/api/aes"))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string theContent = await content.ReadAsStringAsync();
                            dynamic json = JsonConvert.DeserializeObject(theContent);
                            //aesKeysBox.Text += Convert.ToString(json);
                            Newtonsoft.Json.Linq.JObject additionalKeys = json.additionalKeys;
                            aesKeysTable.RowCount = additionalKeys.Count;


                            TextBox mainKeyLabel = new TextBox();
                            mainKeyLabel.ForeColor = Color.White;
                            mainKeyLabel.Multiline = true;
                            mainKeyLabel.BackColor = Color.FromArgb(255, 31, 31, 31);
                            mainKeyLabel.BorderStyle = BorderStyle.None;
                            mainKeyLabel.ReadOnly = true;
                            mainKeyLabel.Dock = DockStyle.Fill;
                            mainKeyLabel.Text = "mainkey";
                            mainKey.Controls.Add(mainKeyLabel, 0, 0);

                            TextBox mainKeyLabel2 = new TextBox();
                            mainKeyLabel2.ForeColor = Color.White;
                            mainKeyLabel2.Multiline = true;
                            mainKeyLabel2.BackColor = Color.FromArgb(255, 31, 31, 31);
                            mainKeyLabel2.BorderStyle = BorderStyle.None;
                            mainKeyLabel2.ReadOnly = true;
                            mainKeyLabel2.Dock = DockStyle.Fill;
                            mainKeyLabel2.Text = json.mainKey;
                            mainKey.Controls.Add(mainKeyLabel2, 1, 0);

                            aesKeysTable.RowStyles.Clear();

                            int i = 0;
                            foreach (var x in additionalKeys)
                            {
                                aesKeysTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 10));


                                TextBox label = new TextBox();
                                label.ForeColor = Color.White;
                                label.Multiline = true;
                                label.BackColor = Color.FromArgb(255, 31, 31, 31);
                                label.BorderStyle = BorderStyle.None;
                                label.ReadOnly = true;
                                label.Dock = DockStyle.Fill;
                                label.Text = x.Key;
                                aesKeysTable.Controls.Add(label, 0, i);

                                TextBox label2 = new TextBox();
                                label2.ForeColor = Color.White;
                                label2.Multiline = true;
                                label2.BackColor = Color.FromArgb(255, 31, 31, 31);
                                label2.BorderStyle = BorderStyle.None;
                                label2.ReadOnly = true;
                                label2.Dock = DockStyle.Fill;
                                label2.Text = x.Value.ToString();
                                aesKeysTable.Controls.Add(label2, 1, i);


                                i++;
                            }
                        }

                    }
                }
            } catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://benbotfn.tk:8080/api/aes");
        }
    }
}
