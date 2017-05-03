using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin_Evidea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load Plugin Assembly
            string appPath = Application.StartupPath + "\\Plugin\\MyPlugins.dll";
            Assembly asm = System.Reflection.Assembly.LoadFile(appPath);
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type item in a.GetTypes())
                {
                    if (item.GetInterface("MyPlugin") != null)
                    {
                        MessageBox.Show("DKK");
                    }
                }
            }
        }
        
        private void menuLoad_Click(object sender, EventArgs e)
        {
            //bool control = true;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if (item.Text == "Human Resources")
                //{
                    //control = false;
                    return;
                //}
            }
            //if (control == true)
            //{
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = "Human Resources";
                tsmi.DropDown.Items.Add("Emploies");
                tsmi.DropDown.Items.Add("Recruitment");
                menuStrip1.Items.Insert(0, tsmi);
                //menuStrip1.Items.Add(tsmi);
            //}
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
