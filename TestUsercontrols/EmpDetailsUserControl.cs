using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUsercontrols
{
    public partial class EmpDetailsUserControl : UserControl
    {
        public EmpDetailsUserControl()
        {
            InitializeComponent();
        }

        public void SetData(Employee emp)
        {
            textBox1.Text = emp.Name;
            textBox2.Text = emp.EMail;
            textBox3.Text = emp.Phone;
        }

        public void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public Employee GetData()
        {
            return new Employee
            {
                Name = textBox1.Text,
                EMail = textBox2.Text,
                Phone = textBox3.Text
            };
        }

        public bool ValidateData()
        {
            // Simple validation: check if any field is empty
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Additional validation logic can be added here
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!textBox2.Text.Contains("@") || !textBox2.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
