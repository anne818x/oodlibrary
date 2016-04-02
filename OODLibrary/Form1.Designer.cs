namespace OODLibrary
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.memberList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.borrowList = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.cardNrBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Page";
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
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cardNrBox);
            this.tabPage2.Controls.Add(this.borrowBtn);
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
            // borrowList
            // 
            this.borrowList.FormattingEnabled = true;
            this.borrowList.Location = new System.Drawing.Point(104, 24);
            this.borrowList.Name = "borrowList";
            this.borrowList.Size = new System.Drawing.Size(142, 134);
            this.borrowList.TabIndex = 6;
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
            // borrowBtn
            // 
            this.borrowBtn.Location = new System.Drawing.Point(104, 205);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(142, 23);
            this.borrowBtn.TabIndex = 7;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // cardNrBox
            // 
            this.cardNrBox.Location = new System.Drawing.Point(203, 174);
            this.cardNrBox.Name = "cardNrBox";
            this.cardNrBox.Size = new System.Drawing.Size(43, 20);
            this.cardNrBox.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button videoBtn;
        private System.Windows.Forms.Button cdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardNrBox;
    }
}

