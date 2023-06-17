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
    public partial class UserLoginPanel : Form
    {
        LibraryContext lc = new LibraryContext();
        HashPassword hp = new HashPassword();
       
        public UserLoginPanel()
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
                    UserPanel up = new UserPanel();
                    up._ID = account.ID;
                    
                    this.Hide();
                    up.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemsel bir hata oluştu sonra tekrar deneyin !");
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
