﻿namespace TeamGitTestForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(44, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);

            label1.TabIndex = 0;
            label1.Text = "Tameem";
            // 
            // label2
            // 
            label2.AutoSize = true;

            label2.Location = new Point(44, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);

            label2.TabIndex = 1;
            label2.Text = "Hussein";
            // 
            // label3
            // 
            label3.AutoSize = true;

            label3.Location = new Point(44, 53);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);

            label3.TabIndex = 2;
            label3.Text = "Ahmed";
            // 
            // label4
            // 
            label4.AutoSize = true;

            label4.Location = new Point(44, 70);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);

            label4.TabIndex = 3;
            label4.Text = "Adham";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;

            checkBox1.Location = new Point(44, 88);
            checkBox1.Margin = new Padding(1, 1, 1, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 21);

            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 382);

            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            Margin = new Padding(2, 2, 2, 2);

            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;

        private Label label4;
        private CheckBox checkBox1;
    }
}
