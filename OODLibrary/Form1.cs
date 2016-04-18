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
    public partial class Library : Form
    {
        //Connections to the other classes
        private Reserves Reserves = new Reserves();
        private member member = new member();
        private Transaction Transaction = new Transaction();
        private Borrowed Borrowed = new Borrowed();
        private Returns Returns = new Returns();
        private Payfee payfee = new Payfee();


        enum rstate {book,cd,video,notset};
        rstate reservestate;

        public Library()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reserves.Connect();
        }

        //Displaying all the members in list box
        public void memberShow()
        {
            memberList.Items.Clear();

            String memberString = member.getAllMembers();
            foreach (String mem in memberString.Split('-'))
                memberList.Items.Add(mem);
        }

        //Deleting selected member
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

        //Adding a memeber
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

        //Displaying all the members on button click
        private void showBtn_Click(object sender, EventArgs e)
        {
            memberShow();
        }

        //Display reports
        private void reportBtn_Click(object sender, EventArgs e)
        {
            Transaction.showReport();
        }

        // selected borrowed item
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
                    
                    //add the borrowed item  
                        Borrowed.addBorrow("'" + cardNrBox.Text + "'", "'" + borrowList.SelectedItem.ToString() + "'");
                        Borrowed.setItemBorrowedNotAvailable(borrowList.SelectedItem.ToString());
                        cardNrBox.Clear();
                }
            }


        }

        //Displaying all items that can be borrowed
        private void ShowItemsBtn_Click(object sender, EventArgs e)
        {
            borrowList.Items.Clear();
            String itemsString = Borrowed.getAllItems();

            foreach (String item in itemsString.Split('-'))
            {
                borrowList.Items.Add(item);
            }
        }

        //Borrow item
        private void borrowItemBtn_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                MessageBox.Show("Please enter a valid card number!");
            }
            else if (!string.IsNullOrWhiteSpace(cardNrBox.Text))
            {
                selectItem();
                borrowList.Items.Clear();
                String itemsString = Borrowed.getAllItems();

                foreach (String item in itemsString.Split('-'))
                {
                    borrowList.Items.Add(item);
                }

            }
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

        private void ReserveBookbtn_Click(object sender, EventArgs e)
        {
            reserveselectLB.Items.Clear();
            this.reservescreenLB.Hide();
            String itemString = Reserves.getReservedItems("items");

            foreach (String item in itemString.Split('-'))
            {
                reserveselectLB.Items.Add(item);
            }
            if (itemString == "book")
            {

                reservestate = rstate.book;
            }
            else if (itemString == "cd")
            {

                reservestate = rstate.cd;
            }
            else if (itemString == "video")
            {

                reservestate = rstate.video;
            }
        }

 


        private void Reserve_Click_1(object sender, EventArgs e)
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


        private void showItems_Click(object sender, EventArgs e)
        {
            returnList.Items.Clear();
            String itemsString = Returns.showBorrowedItem();
            if (String.IsNullOrEmpty(itemsString))
            {
                MessageBox.Show("No Items Borrowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (string item in itemsString.Split('/'))
                {
                    returnList.Items.Add(item);
                }
            } 
        }

        private void returnItem_Click(object sender, EventArgs e)
        {
            string itemSelected = returnList.SelectedItem.ToString();
            string[] splitstring = itemSelected.Split('-');
            int itemId = Int32.Parse(splitstring[0]);
            string itemName = splitstring[1];
            string itemType = splitstring[2];
            string type = splitstring[3];
            string isbn = splitstring[4];
            string releaseDate = splitstring[5];
            DateTime relDate;
            if (releaseDate.Equals(" "))
            {
                relDate = Convert.ToDateTime("2015 - 12 - 16");
            }
            else
            {
                relDate = Convert.ToDateTime(releaseDate);
            }
            DateTime startDate = Convert.ToDateTime(splitstring[6]);

            int daysPassed = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(startDate)).TotalDays);
            int age = ((DateTime.Now - relDate).Days);

            if (age <= 365)
            {
                age = 0;
            }
            else
            {
                age /= 365;
            }

            if (itemType == "Book")
            {
                if (type == "Novel" && daysPassed <= 21)
                {
                    MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Returns.returnItem(itemId);
                    Returns.setItemAvailable(itemId);
                }
                else if (type == "Study Book" && daysPassed <= 30)
                {
                    MessageBox.Show("You are returning this book on time", "Details", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Returns.returnItem(itemId);
                    Returns.setItemAvailable(itemId);
                }
                else
                {
                    DialogResult result =
                        MessageBox.Show("You have to pay € " + payfee.calculateFee(daysPassed, type, 0) + " in fees",
                            "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("You have successfully paid and returned your item!", "Details",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Returns.returnItem(itemId);
                        Returns.setItemAvailable(itemId);
                    }
                    else
                    {
                        MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
                    }
                }
            }
            else if (itemType == "CD")
            {
                DialogResult result =
                    MessageBox.Show("You have to pay € " + payfee.calculateFee(daysPassed, type, age) + " in fees",
                        "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your CD!", "Details",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Returns.returnItem(itemId);
                    Returns.setItemAvailable(itemId);
                }
                else
                {
                    MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            else
            {
                DialogResult result =
                    MessageBox.Show("You have to pay € " + payfee.calculateFee(daysPassed, type, 0) + " in fees",
                        "Pay Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You have successfully paid and returned your Videotape!", "Details",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Returns.returnItem(itemId);
                    Returns.setItemAvailable(itemId);
                }
                else
                {
                    MessageBox.Show("Please pay your fees!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
        }

        }
 }