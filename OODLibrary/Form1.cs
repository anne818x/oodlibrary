using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OODLibrary
{
    public partial class Form1 : Form
    {

        private Connection connection = new Connection();
        
        public Form1()
        {
            InitializeComponent();
            
        }


        private void cdBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String cdString = connection.getAllCDs();

            foreach (String cd in cdString.Split('-'))
            {
                borrowList.Items.Add(cd);
            }

            
        }

        public void selectItem()
        {
            string selectedItem = borrowList.SelectedItem.ToString();
            string memberID = cardNrBox.Text;
            DialogResult box = MessageBox.Show("The Borrowed item you want to borrow is: " + selectedItem, "Borrowing", MessageBoxButtons.OKCancel);
            if (box == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(cardNrBox.Text))
                {
                    MessageBox.Show("Please enter your card number in!");
                }
                else if (!string.IsNullOrWhiteSpace(cardNrBox.Text))
                {
                    MessageBox.Show("You have borrowed " + selectedItem);
                    string nullString = null;
                    connection.addBorrow(cardNrBox.Text,nullString , borrowList.SelectedItem.ToString(), nullString);

                    cardNrBox.Clear();
                }
            }
            else if (box == DialogResult.Cancel)
            {

            }
            

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String booksString = connection.getAllBooks();

           foreach(String book in booksString.Split('-'))
           {
                borrowList.Items.Add(book);
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Connect();
            
            
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String tapeString = connection.getAllVidTapes();

            foreach (String tape in tapeString.Split('-'))
            {
                borrowList.Items.Add(tape);
            }
        }

        public void memberShow()
        {
            memberList.Items.Clear();

            String memberString = connection.getAllMembers();
            foreach (String member in memberString.Split('-'))
            {
                memberList.Items.Add(member);
            }
        }
/// <summary>
/// revenue report
/// </summary>
        public void showReport()
        {
            /*generate report to show to team*/
            ArrayList tempArray = new ArrayList();
            var Message="";
            String transactions = connection.getTransactions();

            foreach (String transaction in transactions.Split('-'))
            {
                Message += transaction+ "\n" ;
            }

            Message += "Total Revenue:   " + connection.getTransTotal().ToString();
            MessageBox.Show(Message);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            connection.deleteMember(memberList.SelectedItem.ToString());
            memberShow();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            connection.addMember(nameTxt.Text, ageTxt.Text);
            
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            memberShow();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            selectItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showReport();
        }
    }
}