namespace L03_W4_Summary
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
            userInit1 = new UserInit();
            SuspendLayout();
            // 
            // userInit1
            // 
            userInit1.Location = new Point(12, 39);
            userInit1.Login = "";
            userInit1.Name = "userInit1";
            userInit1.Pin = "";
            userInit1.Size = new Size(357, 109);
            userInit1.TabIndex = 0;
            userInit1.Load += userInit1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 213);
            Controls.Add(userInit1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserInit userInit1;
    }
}
