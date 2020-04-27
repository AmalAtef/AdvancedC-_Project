namespace WindowsFormsApplication1
{
    partial class CountryForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.getId = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newCountry = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.WrongMsg = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delCountryId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.WrongMsg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.MaximumSize = new System.Drawing.Size(150, 50);
            this.label1.MinimumSize = new System.Drawing.Size(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Countries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter ID";
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Location = new System.Drawing.Point(156, 298);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(0, 17);
            this.countryName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getId
            // 
            this.getId.Location = new System.Drawing.Point(159, 204);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(132, 22);
            this.getId.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(64, 134);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(315, 4);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(161, 153);
            this.label4.MaximumSize = new System.Drawing.Size(150, 30);
            this.label4.MinimumSize = new System.Drawing.Size(130, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Get By Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(64, 371);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(315, 4);
            this.checkedListBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(137, 378);
            this.label3.MaximumSize = new System.Drawing.Size(190, 30);
            this.label3.MinimumSize = new System.Drawing.Size(130, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add New Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // newCountry
            // 
            this.newCountry.Location = new System.Drawing.Point(159, 452);
            this.newCountry.Name = "newCountry";
            this.newCountry.Size = new System.Drawing.Size(132, 22);
            this.newCountry.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(226, 498);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(65, 32);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // WrongMsg
            // 
            this.WrongMsg.AutoSize = true;
            this.WrongMsg.Location = new System.Drawing.Point(61, 506);
            this.WrongMsg.Name = "WrongMsg";
            this.WrongMsg.Size = new System.Drawing.Size(0, 17);
            this.WrongMsg.TabIndex = 16;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(64, 559);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(315, 4);
            this.checkedListBox3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(137, 577);
            this.label7.MaximumSize = new System.Drawing.Size(190, 30);
            this.label7.MinimumSize = new System.Drawing.Size(130, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Delete Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 635);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Enter ID";
            // 
            // delCountryId
            // 
            this.delCountryId.Location = new System.Drawing.Point(159, 633);
            this.delCountryId.Name = "delCountryId";
            this.delCountryId.Size = new System.Drawing.Size(132, 22);
            this.delCountryId.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 673);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WrongMsg2
            // 
            this.WrongMsg2.AutoSize = true;
            this.WrongMsg2.Location = new System.Drawing.Point(61, 690);
            this.WrongMsg2.Name = "WrongMsg2";
            this.WrongMsg2.Size = new System.Drawing.Size(0, 17);
            this.WrongMsg2.TabIndex = 22;
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 730);
            this.Controls.Add(this.WrongMsg2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delCountryId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.WrongMsg);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.newCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.getId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CountryForm";
            this.Text = "CountryForm";
            this.Load += new System.EventHandler(this.CountryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox getId;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newCountry;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label WrongMsg;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox delCountryId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label WrongMsg2;
    }
}