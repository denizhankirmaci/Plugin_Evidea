using Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlugins
{
    public class MyPlugin : Plugin
    {
        public string Name()
        {
            return "MyPlugin";
        }

        public void Do()
        {
            //MessageBox.Show("Denizhan Deneme");
            ToolStripMenuItem ts = new ToolStripMenuItem();
            ts.Name = "Human Resources";
        }
    }
}
