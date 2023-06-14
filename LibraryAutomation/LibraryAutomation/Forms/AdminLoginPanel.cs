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
    public partial class AdminLoginPanel : Form
    {
        LibraryContext lc = new LibraryContext();
        public AdminLoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            var account =lc.Accounts.FirstOrDefault(a => a.Email == email && a.Password==password);
            if (account != null)
            {
                MessageBox.Show("Hesap var");
            }
            else
            {
                MessageBox.Show("Hesap yok");
            }

        }
    }
}
