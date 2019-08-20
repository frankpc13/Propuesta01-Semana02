using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Semana02_Propuesta01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["kotoha"].ConnectionString);

        public void getEmployeeByName()
        {
            using (SqlCommand command = new SqlCommand("usp_list_employees_2", connection))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "employees");
                        dataGridEmployees.DataSource = dataSet.Tables["employees"];
                        labelTotalEmployees.Text = dataSet.Tables["employees"].Rows.Count.ToString();
                    }
                }
            }
        }
        //When Text inside change
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridEmployees.DataSource;
            bs.Filter = dataGridEmployees.Columns[1].HeaderText.ToString() + "+' '+ " +dataGridEmployees.Columns[2].HeaderText.ToString()+ " LIKE '%" + textSearch.Text + "%' ";
            dataGridEmployees.DataSource = bs;
            labelTotalEmployees.Text = dataGridEmployees.RowCount.ToString();
        }
        //When a gridViewCell is Clicked
        private void dataGridEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridEmployees.CurrentRow.Cells[0].Value);
            using (SqlCommand command = new SqlCommand("usp_filter_by_employee", connection))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@employeeId", codigo);
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "orders");
                        dataGridOrder.DataSource = dataSet.Tables["orders"];
                        labelTotalOrders.Text = dataSet.Tables["orders"].Rows.Count.ToString();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getEmployeeByName();
        }
    }

}
