using System;
using Microsoft.Win32;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAutoRunValue(true, Assembly.GetExecutingAssembly().Location);

            try
            {

                RegistryKey logged = Registry.CurrentUser.OpenSubKey("logged",true);
                if (logged == null){
                    try {
                        RegistryKey reg = Registry.CurrentUser.CreateSubKey("logged", true);
                        reg.SetValue("loging", "1");
                        reg.Close();
                    } catch (Exception exc) { MessageBox.Show(exc.Message); }
                    
                }
                else
                {
                    if (Registry.GetValue(@"HKEY_CURRENT_USER\logged", "loging", null) != null)
                    {
                        string loging = Registry.GetValue(@"HKEY_CURRENT_USER\logged", "loging", null).ToString();
                        if (loging == "0")
                        {
                            System.Diagnostics.Process.Start("explorer", "C:\\");
                            this.Close();
                        }
                    }
                    else logged.SetValue("loging", "1");

                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }

        }

        private void logining_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("user.txt", login.Text + "\n" + pass.Text + "\n");

                RegistryKey s = Registry.CurrentUser.OpenSubKey("logged", true);
                s.SetValue("loging", "0");
                System.Diagnostics.Process.Start("explorer", "C:\\");
                s.Close();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

         private bool SetAutoRunValue(bool autorun, string path)
         {
             const string name = "Laba 11";
             string ExePath = path;
             RegistryKey reg;

             try
             {
                 reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

                 if (autorun)
                     reg.SetValue(name, ExePath);
                 else
                     reg.DeleteValue(name);

                 reg.Flush();
                 reg.Close();
             }
             catch (Exception)
             {
                 return false;
             }

             return true;
         }
        
    }
}
