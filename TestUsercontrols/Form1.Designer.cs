namespace TestUsercontrols
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
            empDetailsUserControl1 = new EmpDetailsUserControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // empDetailsUserControl1
            // 
            empDetailsUserControl1.Location = new Point(51, 51);
            empDetailsUserControl1.Name = "empDetailsUserControl1";
            empDetailsUserControl1.Size = new Size(347, 236);
            empDetailsUserControl1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(480, 87);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 1;
            button1.Text = "Read emp from Db";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(480, 151);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 2;
            button2.Text = "Reset data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(480, 226);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(empDetailsUserControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private EmpDetailsUserControl empDetailsUserControl1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
