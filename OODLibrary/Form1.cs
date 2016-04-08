﻿using System;
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
    public partial class Library : Form
    {

        private Reserves Reserves = new Reserves();
        private member member = new member();
        private Transaction Transaction = new Transaction();
        private Borrowed Borrowed = new Borrowed();
        private Returns Returns = new Returns();
        enum rstate {book,cd,video,notset};
        rstate reservestate;


        private int switchBorrow = 0;
        
        public Library()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reserves.Connect();
        }


        public void memberShow()
        {
            memberList.Items.Clear();

            String memberString = member.getAllMembers();
            foreach (String mem in memberString.Split('-'))
                memberList.Items.Add(mem);
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (memberList.SelectedItem == null)
            {
                MessageBox.Show("Please select show list to select a member you want to delete.");
            }
            else {
                member.deleteMember(memberList.SelectedItem.ToString());
                memberShow();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Please fill in your name");
            }
            else if(string.IsNullOrWhiteSpace(ageTxt.Text))
            {
                MessageBox.Show("Please fill in your age");
            }
            else
            {
                member.addMember(nameTxt.Text, ageTxt.Text);
                nameTxt.Clear();
                ageTxt.Clear();
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            memberShow();
        }

        private void borrowedBooks_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String booksString = Returns.showBorrowedBooks();
            if (String.IsNullOrEmpty(booksString))
            {
                MessageBox.Show("No Books Borrowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (string book in booksString.Split('/'))
                {
                    returnList.Items.Add(book);
                }
            }
        }

        private void borrowedCD_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String cdsString = Returns.showBorrowedCDs();
            cdsString = Returns.showBorrowedCDs();
            if (String.IsNullOrEmpty(cdsString))
            {
                MessageBox.Show("No CDs Borrowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (string cd in cdsString.Split('/'))
                {
                    returnList.Items.Add(cd);
                }
            }
        }

        private void borrowedTapes_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String tapesString = Returns.showBorrowedTapes();
            if (String.IsNullOrEmpty(tapesString))
            {
                MessageBox.Show("No Videotapes Borrowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (string tape in tapesString.Split('/'))
                {
                    returnList.Items.Add(tape);
                } 
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction.showReport();
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
                        
                        Borrowed.addBorrow("'" + cardNrBox.Text + "'", "'" + borrowList.SelectedItem.ToString() + "'", nullString, nullString);
                        Borrowed.setBookBorrowedNotAvailable(borrowList.SelectedItem.ToString());
                        cardNrBox.Clear();
                    }

                    else if (switchBorrow == 1)
                    {

                        Borrowed.addBorrow("'" + cardNrBox.Text + "'", nullString, "'" + borrowList.SelectedItem.ToString() + "'", nullString);
                        Borrowed.setCDBorrowedNotAvailable(borrowList.SelectedItem.ToString());
                        cardNrBox.Clear();
                    }

                    else if (switchBorrow == 2)
                    {

                        Borrowed.addBorrow("'" + cardNrBox.Text + "'", nullString, nullString, "'" + borrowList.SelectedItem.ToString() + "'");
                        Borrowed.setTapeBorrowedNotAvailable(borrowList.SelectedItem.ToString());
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
            String booksString = Borrowed.getAllBooks();

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
            String cdString = Borrowed.getAllCDs();

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
            String tapeString = Borrowed.getAllVidTapes();

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
            if (string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                MessageBox.Show("Select what you want to borrow first!");
            }
            else if (!string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                switchBorrow = 0;
                selectItem();
            }
        }

        private void borrowTapeBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                MessageBox.Show("Select what you want to borrow first!");
            }
            else if (!string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                switchBorrow = 2;
                selectItem();
            }
        }

        private void borrowCDBtn_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                MessageBox.Show("Select what you want to borrow first!");
            }
            else if (!string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                switchBorrow = 1;
                selectItem();
            }
        }

        private void returnBooks_Click(object sender, EventArgs e)
        {
            string bookSelected = returnList.SelectedItem.ToString();
            string[] splitstring = bookSelected.Split(' ');
            int bookId = Int32.Parse(splitstring[0]);
            string name = splitstring[1];
            string type = splitstring[2];
            DateTime startDate = Convert.ToDateTime(splitstring[3]);
            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);
            
            if (type == "Novel" && daysPassed <=21)
            {
                MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Returns.returnBook(bookId);
                Returns.setBookAvailable(bookId);
            }
            else if (type == "Study Book" && daysPassed <= 30)
            {
                MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Returns.returnBook(bookId);
                Returns.setBookAvailable(bookId);
            }
            else
            {
                DialogResult result = MessageBox.Show("You have to pay € " + calculateFee(daysPassed, type, 0) + "in fees", "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your book!", "Details",MessageBoxButtons.OK, MessageBoxIcon.Information );
                    Returns.returnBook(bookId);
                    Returns.setBookAvailable(bookId);
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
            DateTime startDate = Convert.ToDateTime(splitstring[4]);

            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);
            int age = ((DateTime.Now - releaseDate).Days);

            if (age <= 365)
            {
                age = 0;
            }
            else
            {
                age /= 365;
            }

                DialogResult result = MessageBox.Show("You have to pay € " + calculateFee(daysPassed, type, age) + " in fees", "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your CD!", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Returns.returnCD(cdId);
                    Returns.setCDAvailable(cdId);
                }
                else
                {
                    MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
        }

        private void returnTape_Click(object sender, EventArgs e)
        {
            string tapeSelected = returnList.SelectedItem.ToString();
            string[] splitstring = tapeSelected.Split(' ');
            int tapeId = Int32.Parse(splitstring[0]);
            string name = splitstring[1];
            string type = splitstring[2];
            DateTime startDate = Convert.ToDateTime(splitstring[4]);
            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);

            DialogResult result = MessageBox.Show("You have to pay € " + calculateFee(daysPassed, type, 0) + " in fees", "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have successfully paid and returned your videotape!", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Returns.returnTape(tapeId);
                Returns.setTapeAvailable(tapeId);
            }
            else
            {
                MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reservetoggle_Click(object sender, EventArgs e)
        {
            if (this.reservescreenLB.Visible == true)
            {
                this.reservescreenLB.Hide();
            }
            else
            {
                if (this.reserveselectLB.SelectedItem != null)
                {

                    reservescreenLB.Items.Clear();
                    foreach (String item in Reserves.getReservations(reserveselectLB.SelectedIndex,reservestate.ToString()).Split('?'))
                    {
                        reservescreenLB.Items.Add(item);
                    }
                    this.reservescreenLB.Show();
            

                }
                else { MessageBox.Show("please select an Item from the above list"); }
            }
        }

        private void reserveshowhide()
        {
            if (this.reservescreenLB.Visible == true)
            {
                reservescreenLB.Items.Clear();
                this.reservescreenLB.Visible = false;
            }
            else
            {
                reservescreenLB.Items.Clear();
                this.reserveselectLB.ClearSelected();
                this.reservescreenLB.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reserveselectLB.Items.Clear();
            this.reservescreenLB.Hide();
            String booksString = Reserves.getReservedBooks();

            foreach (String book in booksString.Split('-'))
            {
                reserveselectLB.Items.Add(book);
            }
            reservestate = rstate.book;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            reserveselectLB.Items.Clear();
            this.reservescreenLB.Hide();
            String cdString = Reserves.getReservedCDs();
            foreach (String cd in cdString.Split('-'))
            {
                reserveselectLB.Items.Add(cd);
            }
            reservestate = rstate.cd;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reserveselectLB.Items.Clear();
            this.reservescreenLB.Hide();
            String tapeString = Reserves.getReservedVidTapes();

            foreach (String tape in tapeString.Split('-'))
            {
                reserveselectLB.Items.Add(tape);
            }
            reservestate = rstate.video;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(this.textBox1.Text, out x))
            {
                if (this.reserveselectLB.SelectedItem != null)
                {
                    this.Reserves.placeReservation(this.reserveselectLB.SelectedIndex, x, this.reservestate.ToString());
                    MessageBox.Show("Reservation ADDED");
                }
                else
                {
                    MessageBox.Show("please select an item");
                }

            }
            else
            {
                MessageBox.Show("please fill in a an integer");
            }
        }
        
    }
}
