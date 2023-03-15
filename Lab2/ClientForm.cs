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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                Client client = new Client();
                SetClientInfo(client);
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(client);
                        transaction.Commit();
                        LoadClientData();
                        tClient_Id.Text = "";
                        tClient_Surname.Text = "";
                        tClient_Address.Text = "";
                        tClient_Phone.Text = "";
                        tClient_Order_Date.Text = "";
                        tClient_Cargo.Text = "";
                        tClient_Destination_Order.Text = "";
                        tClient_Price.Text = "";
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
        private void SetClientInfo(Client client)
        {
            client.Client_Surname = tClient_Surname.Text;
            client.Client_Address = tClient_Address.Text;
            client.Client_Phone = tClient_Phone.Text;
            client.Client_Order_Date = DateTime.Parse(tClient_Order_Date.Text);
            client.Client_Cargo = tClient_Cargo.Text;
            client.Client_Destination_Order = tClient_Destination_Order.Text;
            client.Client_Price = Int32.Parse(tClient_Price.Text);
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
                        IQuery query = session.CreateQuery("from Client where Client_Id = '" + tClient_Id.Text + "'");
                        Client clientData = query.List<Client>()[0];
                        SetClientInfo(clientData);
                        session.Update(clientData);
                        transaction.Commit();
                        LoadClientData();
                        tClient_Id.Text = "";
                        tClient_Surname.Text = "";
                        tClient_Address.Text = "";
                        tClient_Phone.Text = "";
                        tClient_Order_Date.Text = "";
                        tClient_Cargo.Text = "";
                        tClient_Destination_Order.Text = "";
                        tClient_Price.Text = "";
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
                        string client_id = tClient_Id.Text;
                        if (client_id == "")
                        {
                            return;
                        }
                        IQuery queryOne = session.CreateQuery("delete from Orders where Client_Id = " + Int32.Parse(client_id));
                        queryOne.ExecuteUpdate();
                        IQuery queryTwo = session.CreateQuery("delete from Client where Client_Id = " + Int32.Parse(client_id));
                        queryTwo.ExecuteUpdate();
                        transaction.Commit(); ;
                        LoadClientData();
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
            LoadClientData();
        }
        private void LoadClientData()
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("from Client");
                IList<Client> clientInfo = query.List<Client>();
                ClientGridView.DataSource = clientInfo;
            }
        }

        private void tClient_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Order_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Destination_Order_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClient_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientGridView.RowCount <= 1 || e.RowIndex < 0)
            {
                return;
            }
            string client_id = ClientGridView[0, e.RowIndex].Value.ToString();
            if (client_id == "")
            {
                return;
            }
            IList<Client> clientInfo = GetDataFromClient(client_id);
            tClient_Id.Text = clientInfo[0].Client_Id.ToString();
            tClient_Surname.Text = clientInfo[0].Client_Surname.ToString();
            tClient_Address.Text = clientInfo[0].Client_Address.ToString();
            tClient_Phone.Text = clientInfo[0].Client_Phone.ToString();
            tClient_Order_Date.Text = clientInfo[0].Client_Order_Date.ToString();
            tClient_Cargo.Text = clientInfo[0].Client_Cargo.ToString();
            tClient_Destination_Order.Text = clientInfo[0].Client_Destination_Order.ToString();
            tClient_Price.Text = clientInfo[0].Client_Price.ToString();
        }
        private IList<Client> GetDataFromClient(string client_id)
        {
            ISession session = SessionFactory.OpenSession;
            using (session)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        IQuery query = session.CreateQuery("from Client where client_id = '" + client_id + "'");
                        return query.List<Client>();
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
