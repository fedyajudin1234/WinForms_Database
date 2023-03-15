using Lab2.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void tEmployee_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Date_of_Birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Job_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Hire_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Hire_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                Employee employee = new Employee();
                SetEmployeeInfo(employee);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(employee);
                        transaction.Commit();
                        LoadEmployeeData();
                        tEmployee_Id.Text = "";
                        tEmployee_Name.Text = "";
                        tEmployee_Surname.Text = "";
                        tEmployee_Address.Text = "";
                        tEmployee_Date_of_Birth.Text = "";
                        tEmployee_Job.Text = "";
                        tEmployee_Salary.Text = "";
                        tEmployee_Hire_Number.Text = "";
                        tEmployee_Hire_Date.Text = "";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
            }
        }
        private void SetEmployeeInfo(Employee employee)
        {
            employee.Employee_Name = tEmployee_Name.Text;
            employee.Employee_Surname = tEmployee_Surname.Text;
            employee.Employee_Address = tEmployee_Address.Text;
            employee.Employee_Date_Of_Birth = DateTime.Parse(tEmployee_Date_of_Birth.Text);
            employee.Employee_Job = tEmployee_Job.Text;
            employee.Employee_Salary = Int32.Parse(tEmployee_Salary.Text);
            employee.Employee_Hire_Number = tEmployee_Hire_Number.Text;
            employee.Employee_Hire_Date = DateTime.Parse(tEmployee_Hire_Date.Text);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Employee where Employee_Id = '" + tEmployee_Id.Text + "'");
                        Employee employeeData = query.List<Employee>()[0];
                        SetEmployeeInfo(employeeData);
                        session.Update(employeeData);
                        transaction.Commit();
                        LoadEmployeeData();
                        tEmployee_Id.Text = "";
                        tEmployee_Name.Text = "";
                        tEmployee_Surname.Text = "";
                        tEmployee_Address.Text = "";
                        tEmployee_Date_of_Birth.Text = "";
                        tEmployee_Job.Text = "";
                        tEmployee_Salary.Text = "";
                        tEmployee_Hire_Number.Text = "";
                        tEmployee_Hire_Date.Text = "";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        string employee_id = tEmployee_Id.Text;
                        if (employee_id == "")
                        {
                            return;
                        }
                        IQuery queryOne = session.CreateQuery("delete from Driver where Employee_Id = " + Int32.Parse(employee_id));
                        queryOne.ExecuteUpdate();
                        IQuery queryTwo = session.CreateQuery("delete from Employee where Employee_Id = " + Int32.Parse(employee_id));
                        queryTwo.ExecuteUpdate();
                        transaction.Commit();
                        LoadEmployeeData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("from Employee");
                IList<Employee> employeeInfo = query.List<Employee>();
                EmployeeGridView.DataSource = employeeInfo;
            }
        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeGridView.RowCount <= 1 || e.RowIndex < 0)
            {
                return;
            }
            string employee_id = EmployeeGridView[0, e.RowIndex].Value.ToString();
            if (employee_id == "")
            {
                return;
            }
            IList<Employee> employeeInfo = GetDataFromEmployee(employee_id);
            tEmployee_Id.Text = employeeInfo[0].Employee_Id.ToString();
            tEmployee_Name.Text = employeeInfo[0].Employee_Name.ToString();
            tEmployee_Surname.Text = employeeInfo[0].Employee_Surname.ToString();
            tEmployee_Address.Text = employeeInfo[0].Employee_Address.ToString();
            tEmployee_Date_of_Birth.Text = employeeInfo[0].Employee_Date_Of_Birth.ToString();
            tEmployee_Job.Text = employeeInfo[0].Employee_Job.ToString();
            tEmployee_Salary.Text = employeeInfo[0].Employee_Salary.ToString();
            tEmployee_Hire_Number.Text = employeeInfo[0].Employee_Hire_Number.ToString();
            tEmployee_Hire_Date.Text = employeeInfo[0].Employee_Hire_Date.ToString();
        }
        private IList<Employee> GetDataFromEmployee(string employee_id)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Employee where employee_id = '" + employee_id + "'");
                        return query.List<Employee>();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
