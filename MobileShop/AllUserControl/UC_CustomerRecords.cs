using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop.AllUserControl
{
    public partial class UC_CustomerRecords : UserControl
    {
        function fun = new function();
        String query;
        public UC_CustomerRecords()
        {
            InitializeComponent();
        }

        private void UC_CustomerRecords_Enter(object sender, EventArgs e)
        {
            query = "select * from customerPurchase";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        Boolean flag;

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                flag = false;
                labelToSet.Text = "Введите имя клиента";
            }
            else if (txtSearchBy.SelectedIndex == 1) 
            {
                flag = true;
                labelToSet.Text = "Введите IMEI устройства";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like '" + txtSearch.Text + "%'";
                DataSet ds = fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerPurchase where imei like '" + txtSearch.Text + "%'";
                DataSet ds = fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
