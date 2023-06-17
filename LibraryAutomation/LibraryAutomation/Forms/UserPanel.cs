using LibraryAutomation.Context;
using LibraryAutomation.Models;
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
    public partial class UserPanel : Form
    {
        private int _ID;
        LibraryContext lc = new LibraryContext();

        public UserPanel(int ID)
        {
            _ID = ID;
        }

        private void getAllBooks()
        {
            List<Book> books = lc.Books.Where(b => b.IsActive == true).ToList();
            dataGridView1.DataSource = books;
        }
        private void showSelectedGroupBox(GroupBox groupBox)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

            groupBox.Visible = true;
        }
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox2);
            getAllBooks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox3);
            List<Author> authors=lc.Authors.Where(au=>au.IsActive == true).ToList();
            dataGridView2.DataSource = authors;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox2);
            getAllBooks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox4);
            List<BookType> bookTypes = lc.BookTypes.Where(bt => bt.IsActive == true).ToList();
            dataGridView3.DataSource = bookTypes;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string searchName = textBox1.Text;
            List<Book> books = lc.Books.Where(b => b.IsActive == true && b.Name.StartsWith(searchName)).ToList();
            dataGridView1.DataSource = books;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox5);
            List<Publisher>publishers=lc.Publishers.Where(p => p.IsActive == true).ToList();
            dataGridView4.DataSource = publishers;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSelectedGroupBox(groupBox6);
            var u = lc.Users.FirstOrDefault(u => u.AccountID == _ID);
            List<Transaction> transactions = lc.Transactions.Where(t => t.IsActive == true && t.UserID==u.ID).ToList();
            dataGridView5.DataSource = transactions;

        }
    }
}
