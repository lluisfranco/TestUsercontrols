namespace TestUsercontrols
{
    partial class Form2
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
            empDetailsUserControl1 = new EmpDetailsUserControl();
            SuspendLayout();
            // 
            // empDetailsUserControl1
            // 
            empDetailsUserControl1.Location = new Point(363, 142);
            empDetailsUserControl1.Name = "empDetailsUserControl1";
            empDetailsUserControl1.Size = new Size(347, 236);
            empDetailsUserControl1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(empDetailsUserControl1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private EmpDetailsUserControl empDetailsUserControl1;
    }
}