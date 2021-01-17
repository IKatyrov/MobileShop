
namespace MobileShop.AllUserControl
{
    partial class UC_Customer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.txtImei = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompany = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelInternal = new System.Windows.Forms.Label();
            this.labelExpandable = new System.Windows.Forms.Label();
            this.labelRear = new System.Windows.Forms.Label();
            this.labelFront = new System.Windows.Forms.Label();
            this.labelFingerprint = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImei
            // 
            this.txtImei.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImei.DefaultText = "";
            this.txtImei.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImei.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImei.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImei.DisabledState.Parent = this.txtImei;
            this.txtImei.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImei.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImei.FocusedState.Parent = this.txtImei;
            this.txtImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtImei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtImei.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImei.HoverState.Parent = this.txtImei;
            this.txtImei.Location = new System.Drawing.Point(397, 378);
            this.txtImei.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImei.Name = "txtImei";
            this.txtImei.PasswordChar = '\0';
            this.txtImei.PlaceholderText = "";
            this.txtImei.SelectedText = "";
            this.txtImei.ShadowDecoration.Parent = this.txtImei;
            this.txtImei.Size = new System.Drawing.Size(230, 38);
            this.txtImei.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtImei.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(394, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 50;
            this.label13.Text = "IMEI";
            // 
            // txtModel
            // 
            this.txtModel.AutoRoundedCorners = true;
            this.txtModel.BackColor = System.Drawing.Color.Transparent;
            this.txtModel.BorderRadius = 17;
            this.txtModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.FocusedState.Parent = this.txtModel;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.HoverState.Parent = this.txtModel;
            this.txtModel.ItemHeight = 30;
            this.txtModel.ItemsAppearance.Parent = this.txtModel;
            this.txtModel.Location = new System.Drawing.Point(397, 167);
            this.txtModel.Name = "txtModel";
            this.txtModel.ShadowDecoration.Parent = this.txtModel;
            this.txtModel.Size = new System.Drawing.Size(230, 36);
            this.txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtModel.TabIndex = 43;
            this.txtModel.SelectedIndexChanged += new System.EventHandler(this.txtModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(394, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Модель";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoRoundedCorners = true;
            this.txtCompany.BackColor = System.Drawing.Color.Transparent;
            this.txtCompany.BorderRadius = 17;
            this.txtCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCompany.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.FocusedState.Parent = this.txtCompany;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCompany.HoverState.Parent = this.txtCompany;
            this.txtCompany.ItemHeight = 30;
            this.txtCompany.ItemsAppearance.Parent = this.txtCompany;
            this.txtCompany.Location = new System.Drawing.Point(397, 95);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
            this.txtCompany.Size = new System.Drawing.Size(230, 36);
            this.txtCompany.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCompany.TabIndex = 41;
            this.txtCompany.SelectedIndexChanged += new System.EventHandler(this.txtCompany_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(394, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Компания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Электронная почта";
            // 
            // txtGender
            // 
            this.txtGender.AutoRoundedCorners = true;
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderRadius = 17;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(31, 165);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(230, 36);
            this.txtGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGender.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Контактный телефон";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactPhone.DefaultText = "";
            this.txtContactPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactPhone.DisabledState.Parent = this.txtContactPhone;
            this.txtContactPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactPhone.FocusedState.Parent = this.txtContactPhone;
            this.txtContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContactPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContactPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactPhone.HoverState.Parent = this.txtContactPhone;
            this.txtContactPhone.Location = new System.Drawing.Point(31, 237);
            this.txtContactPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.PasswordChar = '\0';
            this.txtContactPhone.PlaceholderText = "";
            this.txtContactPhone.SelectedText = "";
            this.txtContactPhone.ShadowDecoration.Parent = this.txtContactPhone;
            this.txtContactPhone.Size = new System.Drawing.Size(230, 38);
            this.txtContactPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtContactPhone.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Пол";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(31, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(230, 38);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Имя";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BorderRadius = 25;
            this.btnPurchase.BorderThickness = 1;
            this.btnPurchase.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPurchase.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnPurchase.CheckedState.Parent = this.btnPurchase;
            this.btnPurchase.CustomImages.Parent = this.btnPurchase;
            this.btnPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.HoverState.Parent = this.btnPurchase;
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchase.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPurchase.Location = new System.Drawing.Point(397, 423);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.ShadowDecoration.Parent = this.btnPurchase;
            this.btnPurchase.Size = new System.Drawing.Size(175, 45);
            this.btnPurchase.TabIndex = 52;
            this.btnPurchase.Text = "Совершить покупку";
            this.btnPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 65);
            this.label1.TabIndex = 27;
            this.label1.Text = "Покупки клиента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(31, 308);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(230, 38);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 54;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(31, 378);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(230, 38);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "ОЗУ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "Внут.память";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "Доп.память";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 60;
            this.label12.Text = "Осн.камера";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 61;
            this.label14.Text = "Фронт.камера";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 62;
            this.label15.Text = "Датчик пальцев";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(119, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 18);
            this.label16.TabIndex = 63;
            this.label16.Text = "Цена";
            // 
            // labelInternal
            // 
            this.labelInternal.AutoSize = true;
            this.labelInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInternal.Location = new System.Drawing.Point(124, 27);
            this.labelInternal.Name = "labelInternal";
            this.labelInternal.Size = new System.Drawing.Size(31, 15);
            this.labelInternal.TabIndex = 64;
            this.labelInternal.Text = "------";
            // 
            // labelExpandable
            // 
            this.labelExpandable.AutoSize = true;
            this.labelExpandable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpandable.Location = new System.Drawing.Point(124, 44);
            this.labelExpandable.Name = "labelExpandable";
            this.labelExpandable.Size = new System.Drawing.Size(31, 15);
            this.labelExpandable.TabIndex = 65;
            this.labelExpandable.Text = "------";
            // 
            // labelRear
            // 
            this.labelRear.AutoSize = true;
            this.labelRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRear.Location = new System.Drawing.Point(124, 61);
            this.labelRear.Name = "labelRear";
            this.labelRear.Size = new System.Drawing.Size(31, 15);
            this.labelRear.TabIndex = 66;
            this.labelRear.Text = "------";
            // 
            // labelFront
            // 
            this.labelFront.AutoSize = true;
            this.labelFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFront.Location = new System.Drawing.Point(124, 78);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(31, 15);
            this.labelFront.TabIndex = 67;
            this.labelFront.Text = "------";
            // 
            // labelFingerprint
            // 
            this.labelFingerprint.AutoSize = true;
            this.labelFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFingerprint.Location = new System.Drawing.Point(124, 95);
            this.labelFingerprint.Name = "labelFingerprint";
            this.labelFingerprint.Size = new System.Drawing.Size(31, 15);
            this.labelFingerprint.TabIndex = 68;
            this.labelFingerprint.Text = "------";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRam.Location = new System.Drawing.Point(85, 11);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(47, 15);
            this.labelRam.TabIndex = 69;
            this.labelRam.Text = "----------";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(168, 117);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 15);
            this.labelPrice.TabIndex = 70;
            this.labelPrice.Text = "------";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelRam);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelFingerprint);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.labelFront);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.labelInternal);
            this.panel1.Controls.Add(this.labelRear);
            this.panel1.Controls.Add(this.labelExpandable);
            this.panel1.Location = new System.Drawing.Point(397, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 140);
            this.panel1.TabIndex = 71;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtImei);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(680, 487);
            this.Enter += new System.EventHandler(this.UC_Customer_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2TextBox txtImei;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox txtModel;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txtCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtContactPhone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelInternal;
        private System.Windows.Forms.Label labelExpandable;
        private System.Windows.Forms.Label labelRear;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Label labelFingerprint;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
