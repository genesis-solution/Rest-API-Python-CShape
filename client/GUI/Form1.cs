using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        async Task<string> SendRequest(Message msg)
        {
            
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("http://127.0.0.1:8080/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage response = await client.PostAsync("", new StringContent(msg.ToString(), Encoding.UTF8, "application/json"));
                
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
            return "";
        }

        async private void BtnSendA_Click(object sender, EventArgs e)
        {
            string result = await SendRequest(new Message(txtBoxA.Text));
            txtResA.Text = result;
        }

        private async void BtnSendB_Click(object sender, EventArgs e)
        {
            string result = await SendRequest(new Message(txtBoxB.Text));
            txtResB.Text = result;
        }

        private void BtnImgOpen_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog openDlg = new OpenFileDialog();
            // image filters  
            openDlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picOrigin.Image = new Bitmap(openDlg.FileName);
            }
        }

        async private void BtnSendC_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            ImageConverter converter = new ImageConverter();

            string base64String = Convert.ToBase64String((byte[])converter.ConvertTo(picOrigin.Image, typeof(byte[])));
            string result = await SendRequest(new Message(base64String));
            
            Message resMsg = JsonConvert.DeserializeObject<Message>(result);
            byte[] bytes = Convert.FromBase64String(resMsg.data);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                picResponse.Image = Image.FromStream(ms);
            }
            
            stopwatch.Stop();
            labPicRes.Text = "Response in " + stopwatch.ElapsedMilliseconds + "ms";
        }
    }
}
