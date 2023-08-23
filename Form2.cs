using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace StopList
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "111")
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey myKey = currentUserKey.CreateSubKey("MyKey");
                myKey.SetValue("LICENSE", "aсtive");
                myKey.Close();
                currentUserKey.Close();
                MessageBox.Show("Program is activating\nPlease reload program");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is wrong");
            }
        }
    }
}
