namespace WinForm_Txt_read
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.AddFriend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "adress";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(109, 6);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(191, 23);
            this.NameTB.TabIndex = 5;
            // 
            // AdressTB
            // 
            this.AdressTB.Location = new System.Drawing.Point(109, 124);
            this.AdressTB.Multiline = true;
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(191, 148);
            this.AdressTB.TabIndex = 6;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(109, 44);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(191, 23);
            this.SurnameTB.TabIndex = 8;
            // 
            // AddFriend
            // 
            this.AddFriend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFriend.Location = new System.Drawing.Point(159, 292);
            this.AddFriend.Name = "AddFriend";
            this.AddFriend.Size = new System.Drawing.Size(141, 68);
            this.AddFriend.TabIndex = 9;
            this.AddFriend.Tag = "AddFriend";
            this.AddFriend.Text = "AddFriend";
            this.AddFriend.UseVisualStyleBackColor = false;
            this.AddFriend.Click += new System.EventHandler(this.AddFriend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(385, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 350);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // genderCB
            // 
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "None",
            "--Male--",
            "--Female--"});
            this.genderCB.Location = new System.Drawing.Point(109, 83);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(191, 23);
            this.genderCB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 378);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddFriend);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AddFriend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTB;
        private TextBox AdressTB;
        private TextBox SurnameTB;
        private Button AddFriend;
        private RichTextBox richTextBox1;
        private ComboBox genderCB;
    }
}