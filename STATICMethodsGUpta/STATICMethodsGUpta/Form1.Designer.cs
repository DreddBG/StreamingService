namespace STATICMethodsGUpta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowU = new System.Windows.Forms.Button();
            this.btnRemoveU = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBoxAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFavorite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowS = new System.Windows.Forms.Button();
            this.btnRemoveS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-288, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowU);
            this.tabPage1.Controls.Add(this.btnRemoveU);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbUsers);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowU
            // 
            this.btnShowU.Location = new System.Drawing.Point(369, 339);
            this.btnShowU.Name = "btnShowU";
            this.btnShowU.Size = new System.Drawing.Size(101, 47);
            this.btnShowU.TabIndex = 16;
            this.btnShowU.Text = "Show Users";
            this.btnShowU.UseVisualStyleBackColor = true;
            // 
            // btnRemoveU
            // 
            this.btnRemoveU.Location = new System.Drawing.Point(749, 339);
            this.btnRemoveU.Name = "btnRemoveU";
            this.btnRemoveU.Size = new System.Drawing.Size(101, 47);
            this.btnRemoveU.TabIndex = 15;
            this.btnRemoveU.Text = "Remove Selected User";
            this.btnRemoveU.UseVisualStyleBackColor = true;
            this.btnRemoveU.Click += new System.EventHandler(this.btnRemoveU_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbBoxAdress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.btnFavorite);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbFavorite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbAddName);
            this.groupBox2.Location = new System.Drawing.Point(30, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 278);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adress";
            // 
            // tbBoxAdress
            // 
            this.tbBoxAdress.Location = new System.Drawing.Point(78, 96);
            this.tbBoxAdress.Name = "tbBoxAdress";
            this.tbBoxAdress.Size = new System.Drawing.Size(158, 25);
            this.tbBoxAdress.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(78, 64);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(158, 25);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(162, 214);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(101, 49);
            this.btnFavorite.TabIndex = 11;
            this.btnFavorite.Text = "Add Favorite Song To User";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(135, 127);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(101, 31);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Favorite Song:";
            // 
            // tbFavorite
            // 
            this.tbFavorite.Location = new System.Drawing.Point(105, 172);
            this.tbFavorite.Name = "tbFavorite";
            this.tbFavorite.Size = new System.Drawing.Size(158, 25);
            this.tbFavorite.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(78, 33);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(158, 25);
            this.tbAddName.TabIndex = 6;
            this.tbAddName.TextChanged += new System.EventHandler(this.tbAddName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(376, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Users";
            // 
            // lbUsers
            // 
            this.lbUsers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 17;
            this.lbUsers.Location = new System.Drawing.Point(369, 62);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(481, 259);
            this.lbUsers.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowS);
            this.tabPage2.Controls.Add(this.btnRemoveS);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbSongs);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Songs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowS
            // 
            this.btnShowS.Location = new System.Drawing.Point(351, 330);
            this.btnShowS.Name = "btnShowS";
            this.btnShowS.Size = new System.Drawing.Size(101, 47);
            this.btnShowS.TabIndex = 12;
            this.btnShowS.Text = "Show Songs";
            this.btnShowS.UseVisualStyleBackColor = true;
            this.btnShowS.Click += new System.EventHandler(this.btnShowS_Click);
            // 
            // btnRemoveS
            // 
            this.btnRemoveS.Location = new System.Drawing.Point(731, 330);
            this.btnRemoveS.Name = "btnRemoveS";
            this.btnRemoveS.Size = new System.Drawing.Size(101, 47);
            this.btnRemoveS.TabIndex = 11;
            this.btnRemoveS.Text = "Remove Selected Song";
            this.btnRemoveS.UseVisualStyleBackColor = true;
            this.btnRemoveS.Click += new System.EventHandler(this.btnRemoveS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSName);
            this.groupBox1.Location = new System.Drawing.Point(30, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 278);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a song";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Singer:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 25);
            this.textBox2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 41);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Song";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Durations(Seconds):";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(134, 103);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(120, 25);
            this.tbLength.TabIndex = 8;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(59, 33);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(158, 25);
            this.tbSName.TabIndex = 6;
            this.tbSName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(358, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Songs";
            // 
            // lbSongs
            // 
            this.lbSongs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 17;
            this.lbSongs.Location = new System.Drawing.Point(351, 53);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(481, 259);
            this.lbSongs.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kristian\'s music stream";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Button btnRemoveS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFavorite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnShowU;
        private System.Windows.Forms.Button btnShowS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBoxAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
    }
}

