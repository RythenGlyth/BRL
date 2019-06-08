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
                            aesKeysBox.Text += Convert.ToString(json);
                        }

                    }
                }
            } catch(Exception)
            {

            }
        }
    }
}
