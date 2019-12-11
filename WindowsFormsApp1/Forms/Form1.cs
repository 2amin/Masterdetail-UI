using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           MessageBox.Show("Are you sure To Exit");
            
            if (Convert.ToBoolean(DialogResult.OK)==true)
            {
                Application.Exit();
            }
        }
    }
}
