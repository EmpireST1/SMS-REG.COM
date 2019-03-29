using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_SMS_REG.COM;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SMS_REG.COM
{
    public partial class Form1 : Form
    {
        private string GetNum(int i)
        {
            return Main.Rows[i].Cells[0].Value.ToString();
        }
        private string GetCountry(int i)
        {
            return Main.Rows[i].Cells[1].Value.ToString();
        }
        private string GetCode(int i)
        {
            return Main.Rows[i].Cells[2].Value.ToString();
        }
        private string GetTzid(int i)
        {
            return Main.Rows[i].Cells[4].Value.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            timer = new Timer() { Interval = 100000 };
            timer.Tick += timer_TickAsync;
            Fill();
            LoadAll();
        }
        Timer timer;
        async void timer_TickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ApiKey.Text.Trim()))
                BalanceLabel.Text = "Balance: " + await Task.Run(() => API.GetBalance(ApiKey.Text));
        }
        private static int RowsCount = 0;
        private Dictionary<string, string> countrys = new Dictionary<string, string>();
        private Dictionary<string, string> apps = new Dictionary<string, string>();
        private async void GetNumber_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ApiKey.Text.Trim()))
            {
                timer.Start();
                Main.Rows.Add();
                Main.SetCountry(RowsCount, countrys[Countrys.Text]);
                Main.SetComent(RowsCount, "Getting Number");
                SaveAll();
                string country = countrys[Countrys.Text];
                string app = apps[Apps.Text];
                string apikey = ApiKey.Text;
                var TzidAndNumber = await Task.Run(() => API.GetNumber(country, app, apikey));
                if (TzidAndNumber != null)
                {
                    Main.SetTzid(RowsCount, TzidAndNumber.Item1);
                    Main.SetNumber(RowsCount, TzidAndNumber.Item2);
                    Main.SetComent(RowsCount, "Ready!");
                }
                else
                {
                    Main.SetComent(RowsCount, "Wrong ApiKey!");
                    MessageBox.Show("Wrong ApiKey!");
                }
                RowsCount++;
            }
            else
            {
                MessageBox.Show("Enter your ApiKey!");
            }
            
        }
        private async void setReadyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Main.CurrentCell.RowIndex;
                string tzid = GetTzid(i);
                string apikey = ApiKey.Text;
                string code = await Task.Run(() => API.GetCode(tzid, apikey));
                if (code != null)
                    Main.SetCode(i, code);
                else
                {
                    Main.SetCode(i, "Fail");
                    Main.SetComent(RowsCount, "There are no available codes.");
                }
            }
            catch
            {

            }
        }

        private void setUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Main.CurrentCell.RowIndex;
            try
            {
                string tzid = GetTzid(i);
                string apikey = ApiKey.Text;
                Task.Run(() => API.SetUsed(tzid, apikey));
            }
            catch
            {

            }
            Main.Rows.RemoveAt(i);
            RowsCount--;
        }
        void SaveAll()
        {
            StreamWriter wr = new StreamWriter("app.config");
            wr.WriteLine(ApiKey.Text);
            wr.WriteLine(Countrys.Text, true);
            wr.WriteLine(Apps.Text, true);
            wr.Close();
        }
        void LoadAll()
        {
            try
            {
                StreamReader wr = new StreamReader("app.config");
                ApiKey.Text = wr.ReadLine();
                Countrys.Text = wr.ReadLine();
                Apps.Text = wr.ReadLine();
                wr.Close();
            }
            catch
            {

            }
        }
        void Fill()
        {
            countrys.Add("All", "all");
            countrys.Add("Russia", "ru");
            countrys.Add("Ukraine", "ua");
            countrys.Add("Kazakhstan", "kz");
            countrys.Add("China", "cn");

            apps.Add("Other", "other");
            apps.Add("Aol.com", "aol");
            apps.Add("Gmail.com", "gmail");
            apps.Add("Facebook.com", "facebook");
            apps.Add("Mail.ru", "mailru");
            apps.Add("Vk.com", "vk");
            apps.Add("Ok.ru", "classmates");
            apps.Add("Twitter", "twitter");
            apps.Add("Mamba", "mamba");
            apps.Add("Uber", "uber");
            apps.Add("Telegram", "telegram");
            apps.Add("Badoo", "badoo");
            apps.Add("Drugvokrug", "drugvokrug");
            apps.Add("Avito", "avito");
            apps.Add("OLX", "olx");
            apps.Add("Steam", "steam");
            apps.Add("Fotostrana.ru", "fotostrana");
            apps.Add("Microsoft", "microsoft");
            apps.Add("Viber", "viber");
            apps.Add("WhatsApp", "whatsapp");
            apps.Add("WeChat", "wechat");
            apps.Add("SEOsprint", "seosprint");
            apps.Add("Instagram", "instagram");
            apps.Add("Yahoo", "yahoo");
            apps.Add("Line Messanger", "lineme");
            apps.Add("KakaoTalk", "kakaotalk");
            apps.Add("MeetMe", "meetme");
            apps.Add("Tinder", "tinder");
            apps.Add("Nimses", "nimses");
            apps.Add("Youla.ru", "youla");
            apps.Add("5ka.ru", "5ka");
        }

        private void Main_PoopUp(object sender, DataGridViewCellEventArgs e)
        {
            PoopUp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://social-dating.net/en/about/");
        }
    }
}
