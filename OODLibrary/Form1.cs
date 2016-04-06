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

        private void returnBooks_Click(object sender, EventArgs e)
        {
            string bookSelected = returnList.SelectedItem.ToString();
            string[] splitstring = bookSelected.Split('-');
            int bookId = Int32.Parse(splitstring[0]);
            string name = splitstring[1];
            string type = splitstring[2];
            int borrowPeriod = Int32.Parse(splitstring[3].Substring(13, 2));
            DateTime startDate = Convert.ToDateTime(splitstring[4]);
            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);
            
            if (type == "Novel" && daysPassed <=21)
            {
                MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                connection.returnBook(bookId);
                connection.setBookAvailable(bookId);
            }
            else if (type == "Study Book" && daysPassed <= 30)
            {
                MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                connection.returnBook(bookId);
                connection.setBookAvailable(bookId);
            }
            else
            {
                DialogResult result = MessageBox.Show("You have to pay € " + calculateFee(daysPassed, type, 0) + "in fees", "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your book!", "Details",MessageBoxButtons.OK, MessageBoxIcon.Information );
                    connection.returnBook(bookId);
                    connection.setBookAvailable(bookId);
                }
                else
                {
                    MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        
        private void returnCD_Click(object sender, EventArgs e)
        {
            string cdSelected = returnList.SelectedItem.ToString();
            string[] splitstring = cdSelected.Split('-');
            int cdId = Int32.Parse(splitstring[0]);
            string name = splitstring[1];
            string type = splitstring[2];
            DateTime releaseDate = Convert.ToDateTime(splitstring[3]);
            DateTime startDate = Convert.ToDateTime(splitstring[5]);

            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);
            TimeSpan age = (DateTime.Now - releaseDate);

            MessageBox.Show(age.ToString());
            if (type == "Classical" && daysPassed <= 21)
            {
                MessageBox.Show("You are returning this CD on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                connection.returnCD(cdId);
                connection.setCDAvailable(cdId);
            }
            else if (type == "Popular" && daysPassed <= 30)
            {
                MessageBox.Show("You are returning this CD on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                connection.returnCD(cdId);
                connection.setCDAvailable(cdId);
            }
            else
            {
                DialogResult result = MessageBox.Show("You have to pay € " + calculateFee(daysPassed, type, 0) + "in fees", "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your CD!", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.returnCD(cdId);
                    connection.setCDAvailable(cdId);
                }
                else
                {
                    MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void returnTape_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method used for calculation of the fee that a user has to pay
        /// </summary>
        /// <param name="totalDays"></param>
        /// <param name="type"></param>
        /// <param name="age"></param>
        /// <returns> Double with the amount of money that you have to pay</returns>
        public double calculateFee(int totalDays, String type, int age)
        {
            if (type.Equals("Novel"))
            {
                if (totalDays > 21)
                {
                    return ((totalDays - 21) * 0.25);
                }
                else
                {
                    return 0;
                }
            }
            else if (type.Equals("Study Book"))
            {
                if (totalDays > 30)
                {
                    if (((totalDays - 30) % 7) > 0)
                    {
                        return (((totalDays - 30) / 7) + 1);
                    }
                    else
                    {
                        return ((totalDays - 30) / 7);
                    }
                }
                else
                {
                    return 0;
                }
            }
            else if (type.Equals("Classical"))
            {
                double totalCost = 0;

                if (totalDays > 10)
                {
                    if (((totalDays - 10) % 7) > 0)
                    {
                        totalCost = ((((totalDays - 10) / 7) + 1) * 1.50) + 2;
                    }
                    else
                    {
                        totalCost = (((totalDays - 10) / 7) * 1.50) + 2;
                    }
                }
                else
                {
                    totalCost = 2;
                }

                if (age > 1 && age < 5)
                {
                    return (totalCost * 0.90);
                }
                else if (age > 5)
                {
                    return (totalCost * 0.50);
                }
                else
                {
                    return totalCost;
                }
            }
            else if (type.Equals("Popular"))
            {
                double totalCost = 0;

                if (totalDays > 10)
                {
                    if (((totalDays - 10) % 7) > 0)
                    {
                        totalCost = ((((totalDays - 10) / 7) + 1) * 2) + 1;
                    }
                    else
                    {
                        totalCost = (((totalDays - 10) / 7) * 2) + 1;
                    }
                }
                else
                {
                    totalCost = 1;
                }

                if (age > 1 && age < 5)
                {
                    return (totalCost * 0.90);
                }
                else if (age > 5)
                {
                    return (totalCost * 0.50);
                }
                else
                {
                    return totalCost;
                }
            }
            else if (type.Equals("A"))
            {
                return (totalDays * 2);
            }
            else if (type.Equals("B"))
            {
                if (totalDays > 3)
                {
                    return ((totalDays - 3) + 2);
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}