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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer1.Start();
            guna2ShadowPanel1.Visible = false;
            label1.Enabled = true;
            label1.Visible = true;
            guna2WinProgressIndicator1.Enabled = true;
            guna2WinProgressIndicator1.Visible = true;
            guna2WinProgressIndicator1.Start();
        }


        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                if (txtUsername.Text == "IKatyrov" && txtPassword.Text == "myPass")
                {
                    this.Hide();
                    timer1.Start();
                }
                else
                {
                    guna2ShadowPanel1.Enabled = true;
                    labelToShow.Enabled = true;
                    guna2ShadowPanel1.Visible = true;
                    labelToShow.Visible = true;

                    label1.Visible = false;
                    guna2WinProgressIndicator1.Visible = false;

                    label1.Enabled = false;
                    guna2WinProgressIndicator1.Enabled = false;


                    timer1.Stop();
                }
            }
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_Login_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
            labelToShow.Visible = false;
            guna2WinProgressIndicator1.Visible = false;

            label1.Enabled = false;
            labelToShow.Enabled = false;
            guna2WinProgressIndicator1.Enabled = false;
        }

        private void UC_Login_VisibleChanged(object sender, EventArgs e)
        {
            guna2ShadowPanel1.Visible = true;
        }
    }
}
