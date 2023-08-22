using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using MaterialSkin.Controls;
using MaterialSkin;

namespace StopList
{
    public partial class Form1 : MaterialForm
    {

        bool flag = false;
        int worktime;
        int index;
        List<App> apps = new List<App>();
        ManagementEventWatcher startWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
        ManagementEventWatcher stopWatch = new ManagementEventWatcher( new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "APP (*.exe)|*.exe|All files(*.*)|*.*";
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        private void StopApp()
        {

            string str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            var pr = Process.GetProcesses();
            foreach (Process process in pr)
            {
                foreach (App stop in apps)
                {
                    if (process.ProcessName == stop.Name && stop.TimeWork == 0)
                        process.Kill();
                    else if (process.ProcessName == stop.Name && stop.TimeWork > 0)
                        stop.TimeWork--;
                }
            }
            str = JsonSerializer.Serialize(apps);
            File.WriteAllText("jsonData.json", str);
            str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            listBox1.Items.Clear();
            foreach (var item in apps)
            {
                listBox1.Items.Add($"{item.Name} - {item.TimeWork}");
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.OpenSubKey("MyKey");
            if (myKey.GetValue("LICENSE") == null)
            {
                myKey.SetValue("LICENSE", "no");
            }
            string myKeyStr = myKey.GetValue("LICENSE").ToString();
            myKey.Close();
            currentUserKey.Close();
            if (myKeyStr == "active")
            {
                button7.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                button7.Enabled = false;
                button8.Enabled = false;
            }
            string str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            listBox1.Items.Clear();
            foreach (var item in apps)
            {
                listBox1.Items.Add($"{item.Name} - {item.TimeWork}");
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            StopApp();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                index = listBox1.SelectedIndex;
                textBox2.Text = apps[index].Name.ToString();
                textBox4.Text = apps[index].TimeWork.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            return;
        }

         void stopWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string str = e.NewEvent.Properties["ProcessName"].Value.ToString() + " is closed at " + DateTime.Now.ToString();
            listBox2.Items.Add(str);
            File.AppendAllText("track.txt", str);

        }

         void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string str = e.NewEvent.Properties["ProcessName"].Value.ToString() + " is open at " + DateTime.Now.ToString();
            listBox2.Items.Add (str);
            File.AppendAllText("track.txt", str+"\n");
        }


        private void bdel_Click_1(object sender, EventArgs e)
        {
            apps.RemoveAt(index);
            string str = JsonSerializer.Serialize(apps);
            File.WriteAllText("jsonData.json", str);

            str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            listBox1.Items.Clear();
            foreach (var item in apps)
            {
                listBox1.Items.Add($"{item.Name} - {item.TimeWork}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
                worktime = 0;
            else
            {
                try
                {
                    worktime = int.Parse(textBox3.Text);
                }
                catch { }

            }


            App app = new App(textBox1.Text, worktime);
            apps.Add(app);
            string str = JsonSerializer.Serialize(apps);
            File.WriteAllText("jsonData.json", str);

            str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            listBox1.Items.Clear();
            foreach (var item in apps)
            {
                listBox1.Items.Add($"{item.Name} - {item.TimeWork}");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
                worktime = 0;
            else
            {
                try
                {
                    worktime = int.Parse(textBox4.Text);
                }
                catch { }

            }
            App app = new App(textBox2.Text, worktime);
            apps.RemoveAt(index);
            apps.Add(app);
            string str = JsonSerializer.Serialize(apps);
            File.WriteAllText("jsonData.json", str);

            str = File.ReadAllText("jsonData.json");
            apps = JsonSerializer.Deserialize<List<App>>(str);
            listBox1.Items.Clear();
            foreach (var item in apps)
            {
                listBox1.Items.Add($"{item.Name} - {item.TimeWork}");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string result = Path.GetFileName(filename);
            result = result.Substring(0, result.Length - 4);
            if (result != "StopList")
            {
                textBox1.Text = result;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            startWatch.EventArrived += new EventArrivedEventHandler(startWatch_EventArrived);
            startWatch.Start();
            stopWatch.EventArrived += new EventArrivedEventHandler(stopWatch_EventArrived);
            stopWatch.Start();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
        startWatch.Stop();
        stopWatch.Stop();
    }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            bdel.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            bdel.Enabled = true;
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
