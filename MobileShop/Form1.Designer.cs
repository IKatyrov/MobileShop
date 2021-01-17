
namespace MobileShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPhone = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_DeletePhoneRecord1 = new MobileShop.AllUserControl.UC_DeletePhoneRecord();
            this.uC_CustomerRecords1 = new MobileShop.AllUserControl.UC_CustomerRecords();
            this.uC_Stock1 = new MobileShop.AllUserControl.UC_Stock();
            this.uC_Customer1 = new MobileShop.AllUserControl.UC_Customer();
            this.uC_AddNewPhone1 = new MobileShop.AllUserControl.UC_AddNewPhone();
            this.uC_Login1 = new MobileShop.AllUserControl.UC_Login();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCustomerRecords);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnAddNewPhone);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 723);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.uC_Login1);
            this.panel2.Controls.Add(this.uC_DeletePhoneRecord1);
            this.panel2.Controls.Add(this.uC_CustomerRecords1);
            this.panel2.Controls.Add(this.uC_Stock1);
            this.panel2.Controls.Add(this.uC_Customer1);
            this.panel2.Controls.Add(this.uC_AddNewPhone1);
            this.panel2.Location = new System.Drawing.Point(236, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 722);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(9, 474);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerify
            // 
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(1, 516);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(105, 45);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Сверить";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(112, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(105, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMinimize.Location = new System.Drawing.Point(54, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(46, 46);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 26;
            this.btnDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDelete.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(3, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(212, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить телефон";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCustomerRecords
            // 
            this.btnCustomerRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerRecords.BorderRadius = 26;
            this.btnCustomerRecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRecords.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRecords.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerRecords.CheckedState.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.CustomImages.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerRecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerRecords.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecords.HoverState.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRecords.Image")));
            this.btnCustomerRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRecords.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRecords.Location = new System.Drawing.Point(3, 302);
            this.btnCustomerRecords.Name = "btnCustomerRecords";
            this.btnCustomerRecords.ShadowDecoration.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.Size = new System.Drawing.Size(212, 45);
            this.btnCustomerRecords.TabIndex = 3;
            this.btnCustomerRecords.Text = "Записи клиентов";
            this.btnCustomerRecords.Click += new System.EventHandler(this.btnCustomerRecords_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BorderRadius = 26;
            this.btnStock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStock.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStock.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnStock.CheckedState.Parent = this.btnStock;
            this.btnStock.CustomImages.Parent = this.btnStock;
            this.btnStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.HoverState.Parent = this.btnStock;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStock.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStock.Location = new System.Drawing.Point(3, 231);
            this.btnStock.Name = "btnStock";
            this.btnStock.ShadowDecoration.Parent = this.btnStock;
            this.btnStock.Size = new System.Drawing.Size(212, 45);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Склад";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderRadius = 26;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomers.Location = new System.Drawing.Point(3, 160);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(212, 45);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Клиенты";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPhone.BorderRadius = 26;
            this.btnAddNewPhone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewPhone.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewPhone.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddNewPhone.CheckedState.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.CustomImages.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddNewPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPhone.HoverState.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPhone.Image")));
            this.btnAddNewPhone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewPhone.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewPhone.Location = new System.Drawing.Point(3, 89);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.ShadowDecoration.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.Size = new System.Drawing.Size(242, 45);
            this.btnAddNewPhone.TabIndex = 0;
            this.btnAddNewPhone.Text = "Добавить телефон";
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 36;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_DeletePhoneRecord1
            // 
            this.uC_DeletePhoneRecord1.AutoScroll = true;
            this.uC_DeletePhoneRecord1.BackColor = System.Drawing.Color.White;
            this.uC_DeletePhoneRecord1.Location = new System.Drawing.Point(5, 4);
            this.uC_DeletePhoneRecord1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_DeletePhoneRecord1.Name = "uC_DeletePhoneRecord1";
            this.uC_DeletePhoneRecord1.Size = new System.Drawing.Size(972, 718);
            this.uC_DeletePhoneRecord1.TabIndex = 4;
            // 
            // uC_CustomerRecords1
            // 
            this.uC_CustomerRecords1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRecords1.ForeColor = System.Drawing.Color.Transparent;
            this.uC_CustomerRecords1.Location = new System.Drawing.Point(4, 4);
            this.uC_CustomerRecords1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CustomerRecords1.Name = "uC_CustomerRecords1";
            this.uC_CustomerRecords1.Size = new System.Drawing.Size(969, 714);
            this.uC_CustomerRecords1.TabIndex = 3;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.Color.White;
            this.uC_Stock1.Location = new System.Drawing.Point(4, 4);
            this.uC_Stock1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(969, 718);
            this.uC_Stock1.TabIndex = 2;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.White;
            this.uC_Customer1.Location = new System.Drawing.Point(4, 4);
            this.uC_Customer1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(972, 714);
            this.uC_Customer1.TabIndex = 1;
            // 
            // uC_AddNewPhone1
            // 
            this.uC_AddNewPhone1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewPhone1.Location = new System.Drawing.Point(4, 4);
            this.uC_AddNewPhone1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddNewPhone1.Name = "uC_AddNewPhone1";
            this.uC_AddNewPhone1.Size = new System.Drawing.Size(969, 714);
            this.uC_AddNewPhone1.TabIndex = 0;
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.uC_Login1.Location = new System.Drawing.Point(5, 4);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(968, 718);
            this.uC_Login1.TabIndex = 5;
            this.uC_Login1.VisibleChanged += new System.EventHandler(this.uC_Login1_VisibleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1225, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPhone;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRecords;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private AllUserControl.UC_AddNewPhone uC_AddNewPhone1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControl.UC_Customer uC_Customer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControl.UC_Stock uC_Stock1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControl.UC_CustomerRecords uC_CustomerRecords1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControl.UC_DeletePhoneRecord uC_DeletePhoneRecord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControl.UC_Login uC_Login1;
    }
}

