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
    public partial class UC_DeletePhoneRecord : UserControl
    {
        function fun = new function();
        String query;
        public UC_DeletePhoneRecord()
        {
            InitializeComponent();
        }

        private void UC_DeletePhoneRecord_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where cname like'" + txtSearch.Text + "%' or mname like '" + txtSearch.Text + "%'";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); //получение строки на которую нажал
            }
            query = "delete from newMobile where mid = " + bid + "";
            if(MessageBox.Show("Удалить строку: " + bid + "?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fun.setData(query);
            }
            else
            {
                MessageBox.Show("Вы отменили процедуру удаления", "Назад <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
