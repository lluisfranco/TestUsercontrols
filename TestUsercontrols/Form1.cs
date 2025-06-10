namespace TestUsercontrols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new Employee object with sample data
            Employee emp = new Employee
            {
                Name = "John Doe",
                EMail = "jd@fim.com",
                Phone = "123-456-7890"
            };
            empDetailsUserControl1.SetData(emp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empDetailsUserControl1.ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (empDetailsUserControl1.ValidateData())
            {
                var emp = empDetailsUserControl1.GetData();
                //save it to db using the emp repository
                MessageBox.Show($"Emp {emp.Name} has benn saved to db");
            }
        }
    }
}
