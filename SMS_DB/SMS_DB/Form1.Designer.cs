﻿namespace SMS_DB
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
            label1 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            addressTxt = new TextBox();
            emailTxt = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(109, 35);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(161, 27);
            nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 94);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 147);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(112, 147);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(161, 27);
            addressTxt.TabIndex = 4;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(109, 94);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(161, 27);
            emailTxt.TabIndex = 5;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(108, 204);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveBtn);
            Controls.Add(emailTxt);
            Controls.Add(addressTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTxt;
        private Label label2;
        private Label label3;
        private TextBox addressTxt;
        private TextBox emailTxt;
        private Button saveBtn;
    }
}