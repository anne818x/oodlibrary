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
            this.ShowItemsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.memberList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.borrowItemBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNrBox = new System.Windows.Forms.TextBox();
            this.borrowList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.returnItem = new System.Windows.Forms.Button();
            this.showItems = new System.Windows.Forms.Button();
            this.returnList = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reservescreenLB = new System.Windows.Forms.ListBox();
            this.reservetoggle = new System.Windows.Forms.Button();
            this.Reserve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reserveselectLB = new System.Windows.Forms.ListBox();
            this.ReserveItembtn = new System.Windows.Forms.Button();
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
            // ShowItemsBtn
            // 
            this.ShowItemsBtn.Location = new System.Drawing.Point(77, 92);
            this.ShowItemsBtn.Name = "ShowItemsBtn";
            this.ShowItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowItemsBtn.TabIndex = 2;
            this.ShowItemsBtn.Text = "Show Items";
            this.ShowItemsBtn.UseVisualStyleBackColor = true;
            this.ShowItemsBtn.Click += new System.EventHandler(this.ShowItemsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Borrow here:";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(6, 222);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(181, 23);
            this.reportBtn.TabIndex = 6;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 277);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.showBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ageTxt);
            this.tabPage1.Controls.Add(this.nameTxt);
            this.tabPage1.Controls.Add(this.memberList);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.reportBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
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
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age:";
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
            this.tabPage2.Controls.Add(this.borrowItemBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cardNrBox);
            this.tabPage2.Controls.Add(this.borrowList);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ShowItemsBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // borrowItemBtn
            // 
            this.borrowItemBtn.Location = new System.Drawing.Point(158, 219);
            this.borrowItemBtn.Name = "borrowItemBtn";
            this.borrowItemBtn.Size = new System.Drawing.Size(142, 23);
            this.borrowItemBtn.TabIndex = 10;
            this.borrowItemBtn.Text = "Borrow";
            this.borrowItemBtn.UseVisualStyleBackColor = true;
            this.borrowItemBtn.Click += new System.EventHandler(this.borrowItemBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your card number:";
            // 
            // cardNrBox
            // 
            this.cardNrBox.Location = new System.Drawing.Point(257, 178);
            this.cardNrBox.Name = "cardNrBox";
            this.cardNrBox.Size = new System.Drawing.Size(43, 20);
            this.cardNrBox.TabIndex = 8;
            // 
            // borrowList
            // 
            this.borrowList.FormattingEnabled = true;
            this.borrowList.Location = new System.Drawing.Point(158, 28);
            this.borrowList.Name = "borrowList";
            this.borrowList.Size = new System.Drawing.Size(142, 134);
            this.borrowList.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.returnItem);
            this.tabPage3.Controls.Add(this.showItems);
            this.tabPage3.Controls.Add(this.returnList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(449, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Return Page";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // returnItem
            // 
            this.returnItem.Location = new System.Drawing.Point(249, 159);
            this.returnItem.Name = "returnItem";
            this.returnItem.Size = new System.Drawing.Size(99, 52);
            this.returnItem.TabIndex = 8;
            this.returnItem.Text = "Return Item";
            this.returnItem.UseVisualStyleBackColor = true;
            this.returnItem.Click += new System.EventHandler(this.returnItem_Click);
            // 
            // showItems
            // 
            this.showItems.Location = new System.Drawing.Point(64, 159);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(99, 52);
            this.showItems.TabIndex = 7;
            this.showItems.Text = "Show Borrowed Items";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.Click += new System.EventHandler(this.showItems_Click);
            // 
            // returnList
            // 
            this.returnList.FormattingEnabled = true;
            this.returnList.Location = new System.Drawing.Point(6, 6);
            this.returnList.Name = "returnList";
            this.returnList.Size = new System.Drawing.Size(437, 147);
            this.returnList.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reservescreenLB);
            this.tabPage4.Controls.Add(this.reservetoggle);
            this.tabPage4.Controls.Add(this.Reserve);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.reserveselectLB);
            this.tabPage4.Controls.Add(this.ReserveItembtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(449, 251);
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
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(216, 215);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(142, 23);
            this.Reserve.TabIndex = 21;
            this.Reserve.Text = "reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Your card number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 217);
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
            // ReserveItembtn
            // 
            this.ReserveItembtn.Location = new System.Drawing.Point(6, 47);
            this.ReserveItembtn.Name = "ReserveItembtn";
            this.ReserveItembtn.Size = new System.Drawing.Size(75, 43);
            this.ReserveItembtn.TabIndex = 12;
            this.ReserveItembtn.Text = "Items to Reserve";
            this.ReserveItembtn.UseVisualStyleBackColor = true;
            this.ReserveItembtn.Click += new System.EventHandler(this.ReserveItembtn_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(470, 340);
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
        private System.Windows.Forms.Button ShowItemsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox borrowList;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardNrBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox returnList;
        private System.Windows.Forms.Button borrowItemBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox reserveselectLB;
        private System.Windows.Forms.Button ReserveItembtn;
        private System.Windows.Forms.ListBox reservescreenLB;
        private System.Windows.Forms.Button reservetoggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showItems;
        private System.Windows.Forms.Button returnItem;
    }
}

