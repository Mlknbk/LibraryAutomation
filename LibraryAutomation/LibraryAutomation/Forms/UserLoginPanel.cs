using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAutomation.Context;
using LibraryAutomation.Models;


namespace LibraryAutomation.Forms
{
    public partial class UserLoginPanel : Form
    {
        LibraryContext lc = new LibraryContext();

        public UserLoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            var account=lc.Accounts.FirstOrDefault(a => a.Email == email && a.Password == password);
            
            if (account != null )
            {
                MessageBox.Show("Hesap var");
            }
            else
            {
                MessageBox.Show("Hesap yok");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserRegisterPanel urp = new UserRegisterPanel();
            urp.Show();
            this.Hide();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
