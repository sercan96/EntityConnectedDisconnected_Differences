using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _20220217_EntityConectedDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btn_connection_Click(object sender, EventArgs e)
        {
            ConnectionQuery1();
        }
        private void btn_disconnection_Click(object sender, EventArgs e)
        {
            DisconnectionQuery1();
        }
        void ConnectionQuery1()
        {
            DateTime baslangic = DateTime.Now;
            SqlConnection con = new SqlConnection("Server=.\\WINCC; Database = Northwind; UID= sa; PWD = synm1996");
            SqlCommand cmd = new SqlCommand("Select OrderID from Orders", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lst_connected.Items.Add(reader.GetInt32(0));
                    }
                }
            }
            catch (InvalidCastException ıce)
            {
                MessageBox.Show(ıce.Message);
            }
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lbl_conper.Text = ts.TotalMilliseconds.ToString();
        }
        void DisconnectionQuery1()
        {
            DateTime baslangic = DateTime.Now;
            SqlDataAdapter da = new SqlDataAdapter("SELECT OrderID FROM Orders", "Server=.\\WINCC; Database = Northwind; UID= sa; PWD = synm1996");
            DataTable dt = new DataTable("Orders");
            try
            {
                da.Fill(dt);
                lst_disconnected.DataSource = dt;
                lst_disconnected.ValueMember = dt.Columns[0].ColumnName;
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    lst_disconnected.Items.Add(dt.Rows[i][0].ToString());
                //}
            }
            catch (InvalidCastException ica)
            {
                MessageBox.Show(ica.Message);
            }
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lbl_dconper.Text = ts.TotalMilliseconds.ToString();
        }

        private void btn_entity_Click(object sender, EventArgs e)
        {
            EntityQuery1();
        }
        void EntityQuery1()
        {
            DateTime baslangic = DateTime.Now;

            NorthwindEntities db = new NorthwindEntities();
            #region LINQ to Entity
            lst_entity.DataSource = db.
                                      Orders
                                      .Select(o => o.OrderID).ToList();
            #endregion
            #region LINQ to SQL
            var result = from o in db.Orders
                         select o.OrderID;
            lst_entity.DataSource = result.ToList();
            #endregion

            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lbl_entityper.Text = ts.TotalMilliseconds.ToString();
        }
    }

}
