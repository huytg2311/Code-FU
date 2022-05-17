using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConnectedLayer
{
    public partial class frmViewProducts : Form
    {
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>();
            string ConnectionString = "server=MSI\\SQLEXPRESS;database=MyStore;uid=sa;pwd=huytg23";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("Select ProductName, UnitPrice from Products", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true) {
                while (reader.Read()) {
                    products.Add(new
                    {
                        ProductName = reader.GetString("ProductName"),
                        UnitPrice = reader.GetDecimal("UnitPrice")
                    }
                        );
                }
                dgvData.DataSource = products;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
