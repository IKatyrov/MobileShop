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

namespace MobileShop.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fun = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }

        //ТРЕБУЕМЫЕ МЕТОДЫ

        public void setComboBox(String query, ComboBox comboBox) //установка данных в comboBox
        {
            SqlDataReader sdr = fun.getForCombo(query); //select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear(); //очистка поля
            query = "select distinct cname from newMobile"; //запрос на выборку поля
            setComboBox(query, txtCompany); //установка данных
        }

        private void clearAllBox() //очитска полей
        {
            List<TextBox> textBoxes = fun.FindControls<TextBox>(this).ToList();
            List<ComboBox> comboBoxes = fun.FindControls<ComboBox>(this).ToList();
            foreach (var allTextBox in textBoxes) { allTextBox.Clear(); }
            foreach (var allComboBox in comboBoxes) { allComboBox.SelectedIndex = -1; }
        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e) //действия после обновления поля компании
        {
            txtModel.Items.Clear(); //очистка зависимого поля
            String cname = txtCompany.Text; //присвоение значения от чего зависеть      
            query = "select mname from newMobile where cname='" + cname + "'"; //запрос на выборку от зависимого поля
            setComboBox(query, txtModel); //установка данных
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e) //действия после обновления поля модели
        {
            query = "select * from newMobile where mname='" + txtModel.Text + "'";
            DataSet ds = fun.getData(query);

            labelRam.Text = ds.Tables[0].Rows[0][3].ToString(); //третий потому что это 3-й по индекску столбец в таблице
            labelInternal.Text = ds.Tables[0].Rows[0][4].ToString();
            labelExpandable.Text = ds.Tables[0].Rows[0][5].ToString();
            labelRear.Text = ds.Tables[0].Rows[0][7].ToString();
            labelFront.Text = ds.Tables[0].Rows[0][8].ToString();
            labelFingerprint.Text = ds.Tables[0].Rows[0][9].ToString();
            labelPrice.Text = ds.Tables[0].Rows[0][12].ToString();

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContactPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" &&
                txtCompany.SelectedIndex != -1 && txtModel.SelectedIndex != -1 && txtImei.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContactPhone.Text);
                String email = txtEmail.Text;
                String address = txtAddress.Text;
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String imei = txtImei.Text;

                query = "insert into customerPurchase (cname, gender, contact, email, caddress, company, model, imei) value ('" + name + "', '" + gender + "', '" + contact + "', '" + email + "', '" + address + "', '" + company + "', '" + model + "', '" + imei + "')";
                fun.setData(query);
                clearAllBox();
                
            }
            else
            {
                MessageBox.Show("Внесите полностью данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
