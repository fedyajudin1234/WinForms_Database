using Lab2.Model;
using NHibernate;
using NHibernate.Hql.Ast;
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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tCar_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            LoadCarData();
        }
        private void LoadCarData()
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("from Car");
                IList<Car> carInfo = query.List<Car>();
                dataCarView.DataSource = carInfo;
            }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                Car car = new Car();
                SetCarInfo(car);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(car);
                        transaction.Commit();
                        LoadCarData();
                        tCar_Id.Text = "";
                        tCar_Mark.Text = "";
                        tCar_Model.Text = "";
                        tCar_Number.Text = "";
                        tCar_Load.Text = "";
                        tCar_Cargo_Type.Text = "";
                        tCar_Condition.Text = "";
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
            }
        }
        private void SetCarInfo(Car car)
        {
            //car.Car_Id = Int32.Parse(tCar_Id.Text);
            car.Car_Mark = tCar_Mark.Text;
            car.Car_Model = tCar_Model.Text;
            car.Car_Number = tCar_Number.Text;
            car.Car_Load = Int32.Parse(tCar_Load.Text);
            car.Car_Cargo_Type = tCar_Cargo_Type.Text;
            car.Car_Condition = Int32.Parse(tCar_Condition.Text);
        }

        private void tCar_Mark_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Model_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Load_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Cargo_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCar_Condition_TextChanged(object sender, EventArgs e)
        {

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
                        IQuery query = session.CreateQuery("from Car where Car_Id = '" + tCar_Id.Text + "'");
                        Car carData = query.List<Car>()[0];
                        SetCarInfo(carData);
                        session.Update(carData);
                        transaction.Commit();
                        LoadCarData();
                        tCar_Id.Text = "";
                        tCar_Mark.Text = "";
                        tCar_Model.Text = "";
                        tCar_Number.Text = "";
                        tCar_Load.Text = "";
                        tCar_Cargo_Type.Text = "";
                        tCar_Condition.Text = "";
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

        private void dataCarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataCarView.RowCount <= 1 || e.RowIndex < 0)
            {
                return;
            }
            string car_id = dataCarView[0, e.RowIndex].Value.ToString();
            if(car_id == "")
            {
                return;
            }
            IList<Car> carInfo = GetDataFromCar(car_id);
            tCar_Id.Text = carInfo[0].Car_Id.ToString();
            tCar_Mark.Text = carInfo[0].Car_Mark.ToString();
            tCar_Model.Text = carInfo[0].Car_Model.ToString();
            tCar_Number.Text = carInfo[0].Car_Number.ToString();
            tCar_Load.Text = carInfo[0].Car_Load.ToString();
            tCar_Cargo_Type.Text = carInfo[0].Car_Cargo_Type.ToString();
            tCar_Condition.Text = carInfo[0].Car_Condition.ToString();
        }
        private IList<Car> GetDataFromCar(string car_id)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Car where car_id = '" + car_id + "'");
                        return query.List<Car>();
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
                        string car_id = tCar_Id.Text;
                        if (car_id == "")
                        {
                            return;
                        }
                        IQuery queryOne = session.CreateQuery("delete from Driver where Car_Id = " + Int32.Parse(car_id));
                        queryOne.ExecuteUpdate();
                        IQuery queryTwo = session.CreateQuery("delete from Car where Car_Id = " + Int32.Parse(car_id));
                        queryTwo.ExecuteUpdate();
                        transaction.Commit();
                        LoadCarData();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
