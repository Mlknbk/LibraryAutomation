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
using LibraryAutomation.Helpers;

namespace LibraryAutomation.Forms
{
    public partial class UserRegisterPanel : Form
    {
        LibraryContext lc = new LibraryContext();
        HashPassword hp = new HashPassword();
        public UserRegisterPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = textBox1.Text;
                string lastname = textBox2.Text;
                string email = textBox3.Text;
                string password = textBox4.Text;
                string passwordrepeat = textBox5.Text;
                DateTime birthdate = dateTimePicker1.Value;
                if (password != passwordrepeat)
                {
                    MessageBox.Show("Şifreler uyumsuz");
                }
                else
                {
                    Account account = new Account();
                    account.Email = email;
                    account.Password = hp.Hash(password);
                    lc.Accounts.Add(account);
                    lc.SaveChanges();
                    var addedAccount = lc.Accounts.FirstOrDefault(a => a.Email == email && a.Password == hp.Hash(password));

                    User user = new User();
                    user.FirstName = firstname;
                    user.LastName = lastname;
                    user.BirthDate = birthdate;
                    user.AccountID = addedAccount.ID;
                    lc.Users.Add(user);
                    lc.SaveChanges();



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemsel bir hata oluştu sonra tekrar deneyin !");
            }
          
        }

        private void UserRegisterPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
