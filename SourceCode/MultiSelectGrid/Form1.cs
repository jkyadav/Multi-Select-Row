using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSelectGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmployeeId = 1, FirstName = "Jitendra", LastName = "Yadav", Designation = "Tester" });
            empList.Add(new Employee() { EmployeeId = 2, FirstName = "Rohit", LastName = "Modi", Designation = "Tester" });
            empList.Add(new Employee() { EmployeeId = 3, FirstName = "Chetan", LastName = "Pandey", Designation = "Engineer" });
            empList.Add(new Employee() { EmployeeId = 4, FirstName = "Ravi", LastName = "Singh", Designation = "Consultant" });
            empList.Add(new Employee() { EmployeeId = 5, FirstName = "Ketan", LastName = "Patel", Designation = "Analyst" });
            empList.Add(new Employee() { EmployeeId = 6, FirstName = "Netaji", LastName = "Fegade", Designation = "Business Analyst" });

            return empList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewUC1.DataSource = GetEmployees();
        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}
