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
    public partial class UC_AddNewPhone : UserControl
    {

        function fun = new function();
        String query;

        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        /*private IEnumerable<T> FindControls<T>(Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T)
                    yield return (T)control;

                foreach (T item in FindControls<T>(control))
                    yield return item;
            }
        }*/

        private void clearAllBox() //очитска полей
        {
            List<TextBox> textBoxes = fun.FindControls<TextBox>(this).ToList();
            List<ComboBox> comboBoxes = fun.FindControls<ComboBox>(this).ToList();
            foreach (var allTextBox in textBoxes) { allTextBox.Clear(); }
            foreach (var allComboBox in comboBoxes) { allComboBox.SelectedIndex = -1; }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" &&
                txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && 
                txtNetwork.Text != "" && txtPrice.Text != "") 
            {
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String ram = txtRam.Text;
                String inter = txtInternal.Text;
                String expandable = txtExpandable.Text;
                String display = txtDisplay.Text;
                String rear = txtRear.Text;
                String front = txtFront.Text;
                String fingerprint = txtFingerprint.Text;
                String sim = txtSim.Text;
                String network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into newMobile (cname, mname,ram, internal, expandable, display, rear, front, finger, sim, network, price) values('" + company + "','" + model + "','" + ram + "','" + inter + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "','" + price + "')";
                fun.setData(query);
            }
            else
            {
                MessageBox.Show("Добавьте полностью данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllBox();
        }
    }
}
