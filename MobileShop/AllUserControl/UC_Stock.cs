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
    public partial class UC_Stock : UserControl
    {
        function fun = new function();
        String query;

        public UC_Stock()
        {
            InitializeComponent();
        }

        private void UC_Stock_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "select * from newMobile where mid=" + bid + "";
                DataSet ds = fun.getData(query);

                labelCompany.Text = ds.Tables[0].Rows[0][1].ToString();
                labelModel.Text = ds.Tables[0].Rows[0][2].ToString();
                labelRam.Text = ds.Tables[0].Rows[0][3].ToString();
                labelInternal.Text = ds.Tables[0].Rows[0][4].ToString();
                labelExpandable.Text = ds.Tables[0].Rows[0][5].ToString();
                labelDisplay.Text = ds.Tables[0].Rows[0][6].ToString();
                labelRaar.Text = ds.Tables[0].Rows[0][7].ToString();
                labelFront.Text = ds.Tables[0].Rows[0][8].ToString();
                labelFingerprint.Text = ds.Tables[0].Rows[0][9].ToString();
                labelSim.Text = ds.Tables[0].Rows[0][10].ToString();
                labelNetwork.Text = ds.Tables[0].Rows[0][11].ToString();
                labelPrice.Text = ds.Tables[0].Rows[0][12].ToString();
            }
        }
    }
}
