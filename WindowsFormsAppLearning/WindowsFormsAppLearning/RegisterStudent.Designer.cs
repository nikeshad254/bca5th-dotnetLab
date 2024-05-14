namespace WindowsFormsAppLearning
{
    partial class RegisterStudent
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
            this.stuNameTxt = new System.Windows.Forms.TextBox();
            this.stuEmailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stuGenderBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.stuAddressTxt = new System.Windows.Forms.TextBox();
            this.stuCountryBox = new System.Windows.Forms.ComboBox();
            this.registerSaveBtn = new System.Windows.Forms.Button();
            this.registerCancelBtn = new System.Windows.Forms.Button();
            this.stuGenderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // stuNameTxt
            // 
            this.stuNameTxt.Location = new System.Drawing.Point(79, 22);
            this.stuNameTxt.Name = "stuNameTxt";
            this.stuNameTxt.Size = new System.Drawing.Size(100, 22);
            this.stuNameTxt.TabIndex = 1;
            // 
            // stuEmailTxt
            // 
            this.stuEmailTxt.Location = new System.Drawing.Point(79, 50);
            this.stuEmailTxt.Name = "stuEmailTxt";
            this.stuEmailTxt.Size = new System.Drawing.Size(100, 22);
            this.stuEmailTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stuGenderBox
            // 
            this.stuGenderBox.Controls.Add(this.radioButton2);
            this.stuGenderBox.Controls.Add(this.radioButton1);
            this.stuGenderBox.Location = new System.Drawing.Point(79, 153);
            this.stuGenderBox.Name = "stuGenderBox";
            this.stuGenderBox.Size = new System.Drawing.Size(200, 46);
            this.stuGenderBox.TabIndex = 7;
            this.stuGenderBox.TabStop = false;
            this.stuGenderBox.Text = "select gender";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // stuAddressTxt
            // 
            this.stuAddressTxt.Location = new System.Drawing.Point(79, 83);
            this.stuAddressTxt.Name = "stuAddressTxt";
            this.stuAddressTxt.Size = new System.Drawing.Size(100, 22);
            this.stuAddressTxt.TabIndex = 8;
            // 
            // stuCountryBox
            // 
            this.stuCountryBox.FormattingEnabled = true;
            this.stuCountryBox.Items.AddRange(new object[] {
            "Nepal",
            "USA",
            "China",
            "India"});
            this.stuCountryBox.Location = new System.Drawing.Point(79, 114);
            this.stuCountryBox.Name = "stuCountryBox";
            this.stuCountryBox.Size = new System.Drawing.Size(121, 24);
            this.stuCountryBox.TabIndex = 9;
            this.stuCountryBox.SelectedIndexChanged += new System.EventHandler(this.stuCountryBox_SelectedIndexChanged);
            // 
            // registerSaveBtn
            // 
            this.registerSaveBtn.Location = new System.Drawing.Point(82, 221);
            this.registerSaveBtn.Name = "registerSaveBtn";
            this.registerSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.registerSaveBtn.TabIndex = 10;
            this.registerSaveBtn.Text = "save";
            this.registerSaveBtn.UseVisualStyleBackColor = true;
            // 
            // registerCancelBtn
            // 
            this.registerCancelBtn.Location = new System.Drawing.Point(175, 221);
            this.registerCancelBtn.Name = "registerCancelBtn";
            this.registerCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.registerCancelBtn.TabIndex = 11;
            this.registerCancelBtn.Text = "Cancel";
            this.registerCancelBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerCancelBtn);
            this.Controls.Add(this.registerSaveBtn);
            this.Controls.Add(this.stuCountryBox);
            this.Controls.Add(this.stuAddressTxt);
            this.Controls.Add(this.stuGenderBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuEmailTxt);
            this.Controls.Add(this.stuNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "RegisterStudent";
            this.Text = "RegisterStudent";
            this.stuGenderBox.ResumeLayout(false);
            this.stuGenderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuNameTxt;
        private System.Windows.Forms.TextBox stuEmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox stuGenderBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox stuAddressTxt;
        private System.Windows.Forms.ComboBox stuCountryBox;
        private System.Windows.Forms.Button registerSaveBtn;
        private System.Windows.Forms.Button registerCancelBtn;
    }
}