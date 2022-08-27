using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Net.NetworkInformation;

namespace HackBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox2.Text;
            System.Net.WebRequest request = System.Net.HttpWebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            
            if (File.Exists(chromePath)==true)
            {
                string website = textBox1.Text;
                var prs = new ProcessStartInfo("chrome.exe");
                prs.Arguments = website;
                Process.Start(prs);
                
            }
            if (File.Exists(chromePath)==false)
            {
                MessageBox.Show("Chrome Is Not Installed! Please Install It!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            //if (File.Exists(chromePath) == true)
            //{
                string website = textBox1.Text;
                var prs = new ProcessStartInfo("chrome.exe");
                prs.Arguments = "virustotal.com/gui/search/http%253A%252F%252F" + textBox3.Text;
                Process.Start(prs);

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            //if (File.Exists(chromePath) == true)
            
                string website = textBox1.Text;
                var prs = new ProcessStartInfo("chrome.exe");
                prs.Arguments = "youtube.com/results?search_query=" + textBox4.Text.Replace(' ', '+'); ;
                Process.Start(prs);

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            //string separator = "+";

           
            
                string website = textBox1.Text;
                var prs = new ProcessStartInfo("chrome.exe");
                prs.Arguments = "google.com/search?q=" + textBox5.Text.Replace(' ', '+'); ;
                Process.Start(prs);

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently in development, check back later!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10:43 PM, 8/26/2022, My new project's (this app's) first version was launched.", "What's New", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V.2: New features, Bug Fixes (Most Likely).", "What's Coming", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing important to show right now. BTW, Please add any bugs on the GitHub!", "Important", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string website = textBox1.Text;
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "duckduckgo.com/?va=j&t=hc&q="+textBox5.Text.Replace(' ', '+')+"&ia=web";
            Process.Start(prs);
        }
    }
}
