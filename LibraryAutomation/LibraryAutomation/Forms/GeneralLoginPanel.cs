using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.Forms
{
    public partial class GeneralLoginPanel : Form
    {
        public GeneralLoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
         
            AdminLoginPanel adminLoginPanel = new AdminLoginPanel();
            adminLoginPanel.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click+= button2_Click;

            UserLoginPanel userLoginPanel= new UserLoginPanel();
            userLoginPanel.Show();
            this.Hide();
            

        }

      
    }
}
