namespace TeamGitTestForm
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
            lblAHMED = new Label();
            SuspendLayout();
            // 
            // lblAHMED
            // 
            lblAHMED.AutoSize = true;
            lblAHMED.Location = new Point(461, 258);
            lblAHMED.Name = "lblAHMED";
            lblAHMED.Size = new Size(114, 41);
            lblAHMED.TabIndex = 0;
            lblAHMED.Text = "Ahmed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 695);
            Controls.Add(lblAHMED);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAHMED;
    }
}
