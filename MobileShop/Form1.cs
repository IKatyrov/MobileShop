using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            uC_AddNewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CustomerRecords1.Visible = false;
            uC_DeletePhoneRecord1.Visible = false;

            enableDisable(false, false, false);
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //свернуть окно
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnCustomerRecords_Click(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = true;
            uC_CustomerRecords1.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true, true, true);
        }

        

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "myPass")
            {
                panel2.Enabled = true;
                uC_DeletePhoneRecord1.Visible = true;
                uC_DeletePhoneRecord1.BringToFront();
                enableDisable(false, false, false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);
        }

        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;

            btnAddNewPhone.PerformClick();
        }
    }
}
