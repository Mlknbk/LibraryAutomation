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
using LibraryAutomation.Helpers;
using LibraryAutomation.Models;

namespace LibraryAutomation.Forms
{
    public partial class AdminLoginPanel : Form
    {
        LibraryContext lc = new LibraryContext();
        HashPassword hp = new HashPassword();
        public AdminLoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBox1.Text;
                string password = textBox2.Text;
                var account = lc.Accounts.FirstOrDefault(a => a.Email == email && a.Password == hp.Hash(password));
                if (account != null)
                {
                    MessageBox.Show("Hesap var");
                }
                else
                {
                    MessageBox.Show("Hesap yok");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sistemsel bir hata oluştu sonra tekrar deneyin !");
            }
            

        }
    }
}
