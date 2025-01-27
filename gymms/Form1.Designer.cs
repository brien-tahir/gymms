namespace gymms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            userRegDate = new DateTimePicker();
            btnUserDelete = new Button();
            btnUserUpdate = new Button();
            btnUserInsert = new Button();
            userDataGridView = new DataGridView();
            txtUpass = new TextBox();
            txtUname = new TextBox();
            txtFullname = new TextBox();
            txtUserID = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label3 = new Label();
            tabPage4 = new TabPage();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            dataGridView3 = new DataGridView();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(219, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(751, 532);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(743, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(userRegDate);
            tabPage2.Controls.Add(btnUserDelete);
            tabPage2.Controls.Add(btnUserUpdate);
            tabPage2.Controls.Add(btnUserInsert);
            tabPage2.Controls.Add(userDataGridView);
            tabPage2.Controls.Add(txtUpass);
            tabPage2.Controls.Add(txtUname);
            tabPage2.Controls.Add(txtFullname);
            tabPage2.Controls.Add(txtUserID);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(743, 504);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // userRegDate
            // 
            userRegDate.Location = new Point(178, 145);
            userRegDate.Name = "userRegDate";
            userRegDate.Size = new Size(357, 23);
            userRegDate.TabIndex = 11;
            // 
            // btnUserDelete
            // 
            btnUserDelete.BackColor = Color.DarkBlue;
            btnUserDelete.ForeColor = Color.White;
            btnUserDelete.Location = new Point(424, 198);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(124, 45);
            btnUserDelete.TabIndex = 10;
            btnUserDelete.Text = "Delete";
            btnUserDelete.UseVisualStyleBackColor = false;
            btnUserDelete.Click += button6_Click;
            // 
            // btnUserUpdate
            // 
            btnUserUpdate.BackColor = Color.DarkBlue;
            btnUserUpdate.ForeColor = Color.White;
            btnUserUpdate.Location = new Point(294, 198);
            btnUserUpdate.Name = "btnUserUpdate";
            btnUserUpdate.Size = new Size(124, 45);
            btnUserUpdate.TabIndex = 9;
            btnUserUpdate.Text = "Update";
            btnUserUpdate.UseVisualStyleBackColor = false;
            btnUserUpdate.Click += btnUserUpdate_Click;
            // 
            // btnUserInsert
            // 
            btnUserInsert.BackColor = Color.DarkBlue;
            btnUserInsert.ForeColor = Color.White;
            btnUserInsert.Location = new Point(164, 198);
            btnUserInsert.Name = "btnUserInsert";
            btnUserInsert.Size = new Size(124, 45);
            btnUserInsert.TabIndex = 8;
            btnUserInsert.Text = "Register";
            btnUserInsert.UseVisualStyleBackColor = false;
            btnUserInsert.Click += btnUserInsert_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(13, 261);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.Size = new Size(709, 247);
            userDataGridView.TabIndex = 7;
            userDataGridView.CellDoubleClick += userDataGridView_CellDoubleClick;
            // 
            // txtUpass
            // 
            txtUpass.Location = new Point(367, 110);
            txtUpass.Name = "txtUpass";
            txtUpass.Size = new Size(168, 23);
            txtUpass.TabIndex = 6;
            txtUpass.Text = "Password";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(178, 110);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(168, 23);
            txtUname.TabIndex = 4;
            txtUname.Text = "Username";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(367, 76);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(168, 23);
            txtFullname.TabIndex = 3;
            txtFullname.Text = "Fullname";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(178, 76);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(168, 23);
            txtUserID.TabIndex = 2;
            txtUserID.Text = "UserID";
            txtUserID.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 1;
            label2.Text = "Users";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox13);
            tabPage3.Controls.Add(textBox12);
            tabPage3.Controls.Add(textBox11);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(743, 504);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Members";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(153, 189);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(168, 23);
            textBox13.TabIndex = 22;
            textBox13.Text = "Status";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(153, 131);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(168, 23);
            textBox12.TabIndex = 21;
            textBox12.Text = "ClassTime";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(153, 160);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(168, 23);
            textBox11.TabIndex = 20;
            textBox11.Text = "Fee";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 306);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(709, 202);
            dataGridView2.TabIndex = 19;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkBlue;
            button7.ForeColor = Color.White;
            button7.Location = new Point(403, 255);
            button7.Name = "button7";
            button7.Size = new Size(124, 41);
            button7.TabIndex = 18;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkBlue;
            button8.ForeColor = Color.White;
            button8.Location = new Point(273, 255);
            button8.Name = "button8";
            button8.Size = new Size(124, 41);
            button8.TabIndex = 17;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkBlue;
            button9.ForeColor = Color.White;
            button9.Location = new Point(143, 255);
            button9.Name = "button9";
            button9.Size = new Size(124, 41);
            button9.TabIndex = 16;
            button9.Text = "Register";
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(342, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 23);
            textBox6.TabIndex = 15;
            textBox6.Text = "PhoneNumber";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(153, 218);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(357, 23);
            textBox7.TabIndex = 14;
            textBox7.Text = "RegDate";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(153, 100);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(168, 23);
            textBox8.TabIndex = 13;
            textBox8.Text = "Address";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(342, 69);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(168, 23);
            textBox9.TabIndex = 12;
            textBox9.Text = "Fullname";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(153, 69);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(168, 23);
            textBox10.TabIndex = 11;
            textBox10.Text = "MemberID";
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 29);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 1;
            label3.Text = "Members";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBox14);
            tabPage4.Controls.Add(textBox15);
            tabPage4.Controls.Add(textBox16);
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(textBox17);
            tabPage4.Controls.Add(textBox18);
            tabPage4.Controls.Add(textBox19);
            tabPage4.Controls.Add(textBox20);
            tabPage4.Controls.Add(textBox21);
            tabPage4.Controls.Add(label4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(743, 504);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Trainee";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(158, 177);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(168, 23);
            textBox14.TabIndex = 34;
            textBox14.Text = "Status";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(158, 119);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(168, 23);
            textBox15.TabIndex = 33;
            textBox15.Text = "ClassTime";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(158, 148);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(168, 23);
            textBox16.TabIndex = 32;
            textBox16.Text = "Salary";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(27, 302);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(709, 202);
            dataGridView3.TabIndex = 31;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkBlue;
            button10.ForeColor = Color.White;
            button10.Location = new Point(403, 243);
            button10.Name = "button10";
            button10.Size = new Size(124, 44);
            button10.TabIndex = 30;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkBlue;
            button11.ForeColor = Color.White;
            button11.Location = new Point(273, 243);
            button11.Name = "button11";
            button11.Size = new Size(124, 44);
            button11.TabIndex = 29;
            button11.Text = "Update";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkBlue;
            button12.ForeColor = Color.White;
            button12.Location = new Point(143, 243);
            button12.Name = "button12";
            button12.Size = new Size(124, 44);
            button12.TabIndex = 28;
            button12.Text = "Register";
            button12.UseVisualStyleBackColor = false;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(347, 89);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(168, 23);
            textBox17.TabIndex = 27;
            textBox17.Text = "PhoneNumber";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(158, 206);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(357, 23);
            textBox18.TabIndex = 26;
            textBox18.Text = "RegDate";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(158, 88);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(168, 23);
            textBox19.TabIndex = 25;
            textBox19.Text = "Address";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(347, 57);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(168, 23);
            textBox20.TabIndex = 24;
            textBox20.Text = "Fullname";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(158, 57);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(168, 23);
            textBox21.TabIndex = 23;
            textBox21.Text = "CoachID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 22);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 1;
            label4.Text = "Trainee";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 528);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(3, 170);
            button3.Name = "button3";
            button3.Size = new Size(211, 44);
            button3.TabIndex = 2;
            button3.Text = "Trainee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 120);
            button2.Name = "button2";
            button2.Size = new Size(211, 44);
            button2.TabIndex = 1;
            button2.Text = "Members";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 70);
            button1.Name = "button1";
            button1.Size = new Size(211, 44);
            button1.TabIndex = 0;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 531);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            MaximumSize = new Size(989, 570);
            MinimumSize = new Size(989, 570);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUpass;
        private TextBox txtUname;
        private TextBox txtFullname;
        private TextBox txtUserID;
        private DataGridView userDataGridView;
        private Button btnUserDelete;
        private Button btnUserUpdate;
        private Button btnUserInsert;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private DataGridView dataGridView2;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private DataGridView dataGridView3;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private DateTimePicker userRegDate;
    }
}
