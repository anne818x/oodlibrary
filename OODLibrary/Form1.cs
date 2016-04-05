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
        private int switchBorrow = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Connect();
            
            
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

        private void borrowedBooks_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String booksString = connection.showBorrowedBooks();

            foreach (string book in booksString.Split('/'))
            {
                returnList.Items.Add(book);
            }
        }

        private void borrowedCD_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String cdsString = connection.showBorrowedCDs();

            foreach (string cd in cdsString.Split('/'))
            {
                returnList.Items.Add(cd);
            }
        }

        private void borrowedTapes_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String tapesString = connection.showBorrowedTapes();

            foreach (string tape in tapesString.Split('/'))
            {
                returnList.Items.Add(tape);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showReport();
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
                    string nullString = "NULL";

                    if (switchBorrow == 0)
                    {

                        connection.addBorrow("'" + cardNrBox.Text + "'", "'" + borrowList.SelectedItem.ToString() + "'", nullString, nullString);

                        cardNrBox.Clear();
                    }

                    else if (switchBorrow == 1)
                    {

                        connection.addBorrow("'" + cardNrBox.Text + "'", nullString, "'" + borrowList.SelectedItem.ToString() + "'", nullString);

                        cardNrBox.Clear();
                    }

                    else if (switchBorrow == 2)
                    {

                        connection.addBorrow("'" + cardNrBox.Text + "'", nullString, nullString, "'" + borrowList.SelectedItem.ToString() + "'");

                        cardNrBox.Clear();
                    }
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

            foreach (String book in booksString.Split('-'))
            {
                borrowList.Items.Add(book);
            }

            borrowBookBtn.Show();
            borrowTapeBtn.Hide();
            borrowCDBtn.Hide();

        }

        private void cdBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String cdString = connection.getAllCDs();

            foreach (String cd in cdString.Split('-'))
            {
                borrowList.Items.Add(cd);
            }

            borrowBookBtn.Hide();
            borrowTapeBtn.Hide();
            borrowCDBtn.Show();


        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String tapeString = connection.getAllVidTapes();

            foreach (String tape in tapeString.Split('-'))
            {
                borrowList.Items.Add(tape);
            }

            borrowBookBtn.Hide();
            borrowTapeBtn.Show();
            borrowCDBtn.Hide();
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            switchBorrow = 0;
            selectItem();
        }

        private void borrowTapeBtn_Click_1(object sender, EventArgs e)
        {
            switchBorrow = 2;
            selectItem();
        }

        private void borrowCDBtn_Click_1(object sender, EventArgs e)
        {
            switchBorrow = 1;
            selectItem();
        }
    }
}