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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
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
                        string driver_id = tDriver_Id.Text;
                        if (driver_id == "")
                        {
                            return;
                        }
                        IQuery queryOne = session.CreateQuery("delete from Orders where Driver_Id = " + Int32.Parse(driver_id));
                        queryOne.ExecuteUpdate();
                        IQuery queryTwo = session.CreateQuery("delete from Driver where Driver_Id = " + Int32.Parse(driver_id));
                        queryTwo.ExecuteUpdate();
                        transaction.Commit();;
                        LoadDriverData();
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

        private void tDriver_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDriver_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDriver_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDriver_Class_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDriver_Experience_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmployee_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                Driver driver = new Driver();
                SetDriverInfo(driver);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(driver);
                        transaction.Commit();
                        LoadDriverData();
                        tDriver_Id.Text = "";
                        tDriver_Name.Text = "";
                        tDriver_Surname.Text = "";
                        tDriver_Class.Text = "";
                        tDriver_Experience.Text = "";
                        tCar_Id.Text = "";
                        tEmployee_Id.Text = "";
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
        private void SetDriverInfo(Driver driver)
        {
            driver.Driver_Name = tDriver_Name.Text;
            driver.Driver_Surname = tDriver_Surname.Text;
            driver.Driver_Class = Int32.Parse(tDriver_Class.Text);
            driver.Driver_Experience = Int32.Parse(tDriver_Experience.Text);
            driver.Car_Id = Int32.Parse(tCar_Id.Text);
            driver.Employee_Id = Int32.Parse(tEmployee_Id.Text);
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
                        IQuery query = session.CreateQuery("from Driver where Driver_Id = '" + tDriver_Id.Text + "'");
                        Driver driverData = query.List<Driver>()[0];
                        SetDriverInfo(driverData);
                        session.Update(driverData);
                        transaction.Commit();
                        LoadDriverData();
                        tDriver_Id.Text = "";
                        tDriver_Name.Text = "";
                        tDriver_Surname.Text = "";
                        tDriver_Class.Text = "";
                        tDriver_Experience.Text = "";
                        tCar_Id.Text = "";
                        tEmployee_Id.Text = "";
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
            LoadDriverData();
        }
        private void LoadDriverData()
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("from Driver");
                IList<Driver> driverInfo = query.List<Driver>();
                DriverGridView.DataSource = driverInfo;
            }
        }

        private void DriverGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DriverGridView.RowCount <= 1 || e.RowIndex < 0)
            {
                return;
            }
            string driver_id = DriverGridView[0, e.RowIndex].Value.ToString();
            if (driver_id == "")
            {
                return;
            }
            IList<Driver> driverInfo = GetDataFromDriver(driver_id);
            tDriver_Id.Text = driverInfo[0].Driver_Id.ToString();
            tDriver_Name.Text = driverInfo[0].Driver_Name.ToString();
            tDriver_Surname.Text = driverInfo[0].Driver_Surname.ToString();
            tDriver_Class.Text = driverInfo[0].Driver_Class.ToString();
            tDriver_Experience.Text = driverInfo[0].Driver_Experience.ToString();
            tCar_Id.Text = driverInfo[0].Car_Id.ToString();
            tEmployee_Id.Text = driverInfo[0].Employee_Id.ToString();
        }
        private IList<Driver> GetDataFromDriver(string driver_id)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Driver where driver_id = '" + driver_id + "'");
                        return query.List<Driver>();
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

        private void DriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
