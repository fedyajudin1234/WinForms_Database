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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void tOrder_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDriver_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                Orders orders = new Orders();
                SetOrdersInfo(orders);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(orders);
                        transaction.Commit();
                        LoadOrdersData();
                        tOrder_Id.Text = "";
                        tClient_Id.Text = "";
                        tDriver_Id.Text = "";
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
        private void SetOrdersInfo(Orders orders)
        {
            orders.Client_Id = Int32.Parse(tClient_Id.Text);
            orders.Driver_Id = Int32.Parse(tDriver_Id.Text);
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
                        IQuery query = session.CreateQuery("from Orders where Order_Id = '" + tOrder_Id.Text + "'");
                        Orders ordersData = query.List<Orders>()[0];
                        SetOrdersInfo(ordersData);
                        session.Update(ordersData);
                        transaction.Commit();
                        LoadOrdersData();
                        tOrder_Id.Text = "";
                        tClient_Id.Text = "";
                        tDriver_Id.Text = "";
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
                        string order_id = tOrder_Id.Text;
                        if (order_id == "")
                        {
                            return;
                        }
                        IQuery query = session.CreateQuery("delete from Orders where Order_Id = " + Int32.Parse(order_id));
                        query.ExecuteUpdate();
                        transaction.Commit(); ;
                        LoadOrdersData();
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
            LoadOrdersData();
        }
        private void LoadOrdersData()
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("from Orders");
                IList<Orders> ordersInfo = query.List<Orders>();
                OrdersGridView.DataSource = ordersInfo;
            }
        }

        private void OrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersGridView.RowCount <= 1 || e.RowIndex < 0)
            {
                return;
            }
            string order_id = OrdersGridView[0, e.RowIndex].Value.ToString();
            if (order_id == "")
            {
                return;
            }
            IList<Orders> ordersInfo = GetDataFromOrders(order_id);
            tOrder_Id.Text = ordersInfo[0].Order_Id.ToString();
            tClient_Id.Text = ordersInfo[0].Client_Id.ToString();
            tDriver_Id.Text = ordersInfo[0].Driver_Id.ToString();
        }
        private IList<Orders> GetDataFromOrders(string order_id)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Orders where order_id = '" + order_id + "'");
                        return query.List<Orders>();
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
    }
}
