namespace OODLibrary
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.videoBtn = new System.Windows.Forms.Button();
            this.cdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportButt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.showBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.memberList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.borrowTapeBtn = new System.Windows.Forms.Button();
            this.borrowCDBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNrBox = new System.Windows.Forms.TextBox();
            this.borrowBookBtn = new System.Windows.Forms.Button();
            this.borrowList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.returnTape = new System.Windows.Forms.Button();
            this.returnCD = new System.Windows.Forms.Button();
            this.returnBooks = new System.Windows.Forms.Button();
            this.borrowedTapes = new System.Windows.Forms.Button();
            this.borrowedCD = new System.Windows.Forms.Button();
            this.borrowedBooks = new System.Windows.Forms.Button();
            this.returnList = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reservescreenLB = new System.Windows.Forms.ListBox();
            this.reservetoggle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reserveselectLB = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(283, 135);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 42);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete Member";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(23, 63);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 2;
            this.bookBtn.Text = "Books";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // videoBtn
            // 
            this.videoBtn.Location = new System.Drawing.Point(23, 121);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(75, 23);
            this.videoBtn.TabIndex = 3;
            this.videoBtn.Text = "Video Tapes";
            this.videoBtn.UseVisualStyleBackColor = true;
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // cdBtn
            // 
            this.cdBtn.Location = new System.Drawing.Point(23, 92);
            this.cdBtn.Name = "cdBtn";
            this.cdBtn.Size = new System.Drawing.Size(75, 23);
            this.cdBtn.TabIndex = 4;
            this.cdBtn.Text = "CDs";
            this.cdBtn.UseVisualStyleBackColor = true;
            this.cdBtn.Click += new System.EventHandler(this.cdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Borrow here:";
            // 
            // reportButt
            // 
            this.reportButt.Location = new System.Drawing.Point(6, 229);
            this.reportButt.Name = "reportButt";
            this.reportButt.Size = new System.Drawing.Size(181, 23);
            this.reportButt.TabIndex = 6;
            this.reportButt.Text = "Generate Report";
            this.reportButt.UseVisualStyleBackColor = true;
            this.reportButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(22, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 284);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.showBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ageTxt);
            this.tabPage1.Controls.Add(this.nameTxt);
            this.tabPage1.Controls.Add(this.memberList);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.reportButt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Page";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(197, 8);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(42, 121);
            this.showBtn.TabIndex = 13;
            this.showBtn.Text = "show list";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(77, 135);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 42);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Member";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(66, 61);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(100, 20);
            this.ageTxt.TabIndex = 9;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(66, 20);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 8;
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(245, 8);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(149, 121);
            this.memberList.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.borrowTapeBtn);
            this.tabPage2.Controls.Add(this.borrowCDBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cardNrBox);
            this.tabPage2.Controls.Add(this.borrowBookBtn);
            this.tabPage2.Controls.Add(this.borrowList);
            this.tabPage2.Controls.Add(this.cdBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bookBtn);
            this.tabPage2.Controls.Add(this.videoBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // borrowTapeBtn
            // 
            this.borrowTapeBtn.Location = new System.Drawing.Point(104, 205);
            this.borrowTapeBtn.Name = "borrowTapeBtn";
            this.borrowTapeBtn.Size = new System.Drawing.Size(142, 23);
            this.borrowTapeBtn.TabIndex = 11;
            this.borrowTapeBtn.Text = "Borrow";
            this.borrowTapeBtn.UseVisualStyleBackColor = true;
            this.borrowTapeBtn.Click += new System.EventHandler(this.borrowTapeBtn_Click_1);
            // 
            // borrowCDBtn
            // 
            this.borrowCDBtn.Location = new System.Drawing.Point(104, 205);
            this.borrowCDBtn.Name = "borrowCDBtn";
            this.borrowCDBtn.Size = new System.Drawing.Size(142, 23);
            this.borrowCDBtn.TabIndex = 10;
            this.borrowCDBtn.Text = "Borrow";
            this.borrowCDBtn.UseVisualStyleBackColor = true;
            this.borrowCDBtn.Click += new System.EventHandler(this.borrowCDBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your card number:";
            // 
            // cardNrBox
            // 
            this.cardNrBox.Location = new System.Drawing.Point(203, 174);
            this.cardNrBox.Name = "cardNrBox";
            this.cardNrBox.Size = new System.Drawing.Size(43, 20);
            this.cardNrBox.TabIndex = 8;
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Location = new System.Drawing.Point(104, 205);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(142, 23);
            this.borrowBookBtn.TabIndex = 7;
            this.borrowBookBtn.Text = "Borrow";
            this.borrowBookBtn.UseVisualStyleBackColor = true;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // borrowList
            // 
            this.borrowList.FormattingEnabled = true;
            this.borrowList.Location = new System.Drawing.Point(104, 24);
            this.borrowList.Name = "borrowList";
            this.borrowList.Size = new System.Drawing.Size(142, 134);
            this.borrowList.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.returnTape);
            this.tabPage3.Controls.Add(this.returnCD);
            this.tabPage3.Controls.Add(this.returnBooks);
            this.tabPage3.Controls.Add(this.borrowedTapes);
            this.tabPage3.Controls.Add(this.borrowedCD);
            this.tabPage3.Controls.Add(this.borrowedBooks);
            this.tabPage3.Controls.Add(this.returnList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(400, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Return Page";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // returnTape
            // 
            this.returnTape.Location = new System.Drawing.Point(281, 210);
            this.returnTape.Name = "returnTape";
            this.returnTape.Size = new System.Drawing.Size(101, 42);
            this.returnTape.TabIndex = 6;
            this.returnTape.Text = "Return Tape";
            this.returnTape.UseVisualStyleBackColor = true;
            this.returnTape.Click += new System.EventHandler(this.returnTape_Click);
            // 
            // returnCD
            // 
            this.returnCD.Location = new System.Drawing.Point(149, 207);
            this.returnCD.Name = "returnCD";
            this.returnCD.Size = new System.Drawing.Size(101, 42);
            this.returnCD.TabIndex = 5;
            this.returnCD.Text = "Return CD";
            this.returnCD.UseVisualStyleBackColor = true;
            this.returnCD.Click += new System.EventHandler(this.returnCD_Click);
            // 
            // returnBooks
            // 
            this.returnBooks.Location = new System.Drawing.Point(18, 207);
            this.returnBooks.Name = "returnBooks";
            this.returnBooks.Size = new System.Drawing.Size(101, 42);
            this.returnBooks.TabIndex = 4;
            this.returnBooks.Text = "Return Book";
            this.returnBooks.UseVisualStyleBackColor = true;
            this.returnBooks.Click += new System.EventHandler(this.returnBooks_Click);
            // 
            // borrowedTapes
            // 
            this.borrowedTapes.Location = new System.Drawing.Point(281, 159);
            this.borrowedTapes.Name = "borrowedTapes";
            this.borrowedTapes.Size = new System.Drawing.Size(101, 42);
            this.borrowedTapes.TabIndex = 3;
            this.borrowedTapes.Text = "Show Borrowed Tapes";
            this.borrowedTapes.UseVisualStyleBackColor = true;
            this.borrowedTapes.Click += new System.EventHandler(this.borrowedTapes_Click);
            // 
            // borrowedCD
            // 
            this.borrowedCD.Location = new System.Drawing.Point(149, 159);
            this.borrowedCD.Name = "borrowedCD";
            this.borrowedCD.Size = new System.Drawing.Size(101, 42);
            this.borrowedCD.TabIndex = 2;
            this.borrowedCD.Text = "Show Borrowed CDs";
            this.borrowedCD.UseVisualStyleBackColor = true;
            this.borrowedCD.Click += new System.EventHandler(this.borrowedCD_Click);
            // 
            // borrowedBooks
            // 
            this.borrowedBooks.Location = new System.Drawing.Point(18, 159);
            this.borrowedBooks.Name = "borrowedBooks";
            this.borrowedBooks.Size = new System.Drawing.Size(101, 42);
            this.borrowedBooks.TabIndex = 1;
            this.borrowedBooks.Text = "Show Borrowed Books";
            this.borrowedBooks.UseVisualStyleBackColor = true;
            this.borrowedBooks.Click += new System.EventHandler(this.borrowedBooks_Click);
            // 
            // returnList
            // 
            this.returnList.FormattingEnabled = true;
            this.returnList.Location = new System.Drawing.Point(6, 6);
            this.returnList.Name = "returnList";
            this.returnList.Size = new System.Drawing.Size(388, 147);
            this.returnList.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reservescreenLB);
            this.tabPage4.Controls.Add(this.reservetoggle);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.reserveselectLB);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(400, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reservation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reservescreenLB
            // 
            this.reservescreenLB.FormattingEnabled = true;
            this.reservescreenLB.Location = new System.Drawing.Point(9, 144);
            this.reservescreenLB.Name = "reservescreenLB";
            this.reservescreenLB.Size = new System.Drawing.Size(385, 56);
            this.reservescreenLB.TabIndex = 23;
            this.reservescreenLB.Visible = false;
            // 
            // reservetoggle
            // 
            this.reservetoggle.Location = new System.Drawing.Point(193, 115);
            this.reservetoggle.Name = "reservetoggle";
            this.reservetoggle.Size = new System.Drawing.Size(142, 23);
            this.reservetoggle.TabIndex = 22;
            this.reservetoggle.Text = "Show reservations";
            this.reservetoggle.UseVisualStyleBackColor = true;
            this.reservetoggle.Click += new System.EventHandler(this.reservetoggle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Your card number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 18;
            // 
            // reserveselectLB
            // 
            this.reserveselectLB.FormattingEnabled = true;
            this.reserveselectLB.Location = new System.Drawing.Point(84, 19);
            this.reserveselectLB.Name = "reserveselectLB";
            this.reserveselectLB.Size = new System.Drawing.Size(251, 95);
            this.reserveselectLB.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "CDs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Choose an item";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Books";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Video Tapes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button videoBtn;
        private System.Windows.Forms.Button cdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportButt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox borrowList;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button borrowBookBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardNrBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox returnList;
        private System.Windows.Forms.Button borrowedTapes;
        private System.Windows.Forms.Button borrowedCD;
        private System.Windows.Forms.Button borrowedBooks;
        private System.Windows.Forms.Button borrowTapeBtn;
        private System.Windows.Forms.Button borrowCDBtn;
        private System.Windows.Forms.Button returnBooks;
        private System.Windows.Forms.Button returnCD;
        private System.Windows.Forms.Button returnTape;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox reserveselectLB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox reservescreenLB;
        private System.Windows.Forms.Button reservetoggle;
    }
}

