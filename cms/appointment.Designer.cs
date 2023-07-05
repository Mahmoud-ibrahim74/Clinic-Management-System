namespace cms
{
    partial class appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.slideMenu = new System.Windows.Forms.Panel();
            this.btmMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.show = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.back = new System.Windows.Forms.Button();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.calc = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.source = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_paid = new System.Windows.Forms.TextBox();
            this.payment_method = new Guna.UI2.WinForms.Guna2ComboBox();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.branch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timing = new Guna.UI2.WinForms.Guna2ComboBox();
            this.body = new Guna.UI2.WinForms.Guna2ComboBox();
            this.kind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TableA = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.panelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.slideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
            this.loader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableA)).BeginInit();
            this.SuspendLayout();
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // tm
            // 
            this.tm.Interval = 5000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.slideMenu.Controls.Add(this.btmMenu);
            this.slideMenu.Controls.Add(this.logo);
            this.slideMenu.Controls.Add(this.bunifuFlatButton1);
            this.slideMenu.Controls.Add(this.show);
            this.slideMenu.Controls.Add(this.logo2);
            this.logoAnimator.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 53);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(75, 647);
            this.slideMenu.TabIndex = 0;
            // 
            // btmMenu
            // 
            this.btmMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelAnimator.SetDecoration(this.btmMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btmMenu, BunifuAnimatorNS.DecorationType.None);
            this.btmMenu.Image = ((System.Drawing.Image)(resources.GetObject("btmMenu.Image")));
            this.btmMenu.ImageActive = null;
            this.btmMenu.Location = new System.Drawing.Point(12, 6);
            this.btmMenu.Name = "btmMenu";
            this.btmMenu.Size = new System.Drawing.Size(52, 39);
            this.btmMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmMenu.TabIndex = 1;
            this.btmMenu.TabStop = false;
            this.btmMenu.Zoom = 10;
            this.btmMenu.Click += new System.EventHandler(this.btmMenu_Click);
            // 
            // logo
            // 
            this.panelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(8, 65);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 72);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "    Add  Appointments ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Constantia", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 494);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(246, 76);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // show
            // 
            this.show.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.BorderRadius = 0;
            this.show.ButtonText = "      Display  Appointments ";
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.show, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.show, BunifuAnimatorNS.DecorationType.None);
            this.show.Font = new System.Drawing.Font("Constantia", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Iconcolor = System.Drawing.Color.Transparent;
            this.show.Iconimage = ((System.Drawing.Image)(resources.GetObject("show.Iconimage")));
            this.show.Iconimage_right = null;
            this.show.Iconimage_right_Selected = null;
            this.show.Iconimage_Selected = null;
            this.show.IconZoom = 90D;
            this.show.IsTab = false;
            this.show.Location = new System.Drawing.Point(3, 300);
            this.show.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.show.Name = "show";
            this.show.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.show.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.show.OnHoverTextColor = System.Drawing.Color.White;
            this.show.selected = true;
            this.show.Size = new System.Drawing.Size(246, 70);
            this.show.TabIndex = 2;
            this.show.Textcolor = System.Drawing.Color.White;
            this.show.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // logo2
            // 
            this.panelAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(28, 31);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(185, 106);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 0;
            this.logo2.TabStop = false;
            this.logo2.Visible = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.back);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1300, 53);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1221, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(23, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.back.Location = new System.Drawing.Point(3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 43);
            this.back.TabIndex = 93;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_2);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1265, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(23, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(575, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(151, 32);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Main Control";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calc);
            this.panel2.Controls.Add(this.loader);
            this.panel2.Controls.Add(this.source);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.left);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.total_paid);
            this.panel2.Controls.Add(this.payment_method);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.branch);
            this.panel2.Controls.Add(this.timing);
            this.panel2.Controls.Add(this.body);
            this.panel2.Controls.Add(this.kind);
            this.panel2.Controls.Add(this.TableA);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.label2);
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(75, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 647);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // calc
            // 
            this.calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calc.BackgroundImage")));
            this.calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.calc, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.calc, BunifuAnimatorNS.DecorationType.None);
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.calc.Location = new System.Drawing.Point(1039, 11);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(36, 34);
            this.calc.TabIndex = 120;
            this.toolTip1.SetToolTip(this.calc, "Open Calculator");
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // loader
            // 
            this.loader.Controls.Add(this.label11);
            this.loader.Controls.Add(this.guna2WinProgressIndicator1);
            this.logoAnimator.SetDecoration(this.loader, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.loader, BunifuAnimatorNS.DecorationType.None);
            this.loader.Location = new System.Drawing.Point(563, 108);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(505, 288);
            this.loader.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(171, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "loading Please wait ........";
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AnimationSpeed = 90;
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.panelAnimator.SetDecoration(this.guna2WinProgressIndicator1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2WinProgressIndicator1, BunifuAnimatorNS.DecorationType.None);
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(194, 40);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2WinProgressIndicator1.TabIndex = 1;
            // 
            // source
            // 
            this.source.Animated = true;
            this.source.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.source, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.source, BunifuAnimatorNS.DecorationType.None);
            this.source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.source.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.source.FocusedState.Parent = this.source;
            this.source.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.source.ForeColor = System.Drawing.Color.White;
            this.source.HoverState.Parent = this.source;
            this.source.IntegralHeight = false;
            this.source.ItemHeight = 30;
            this.source.Items.AddRange(new object[] {
            " Choose Method",
            " Facebook",
            " Call"});
            this.source.ItemsAppearance.Parent = this.source;
            this.source.Location = new System.Drawing.Point(760, 571);
            this.source.Name = "source";
            this.source.ShadowDecoration.Parent = this.source;
            this.source.Size = new System.Drawing.Size(308, 36);
            this.source.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(579, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 115;
            this.label7.Text = "Lead Source";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoAnimator.SetDecoration(this.left, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.left, BunifuAnimatorNS.DecorationType.None);
            this.left.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.left.ForeColor = System.Drawing.Color.White;
            this.left.Location = new System.Drawing.Point(757, 501);
            this.left.Multiline = true;
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(311, 32);
            this.left.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 113;
            this.label3.Text = "Left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(579, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 112;
            this.label1.Text = "Total Paid";
            // 
            // total_paid
            // 
            this.total_paid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.total_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoAnimator.SetDecoration(this.total_paid, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.total_paid, BunifuAnimatorNS.DecorationType.None);
            this.total_paid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.total_paid.ForeColor = System.Drawing.Color.White;
            this.total_paid.Location = new System.Drawing.Point(757, 428);
            this.total_paid.Multiline = true;
            this.total_paid.Name = "total_paid";
            this.total_paid.Size = new System.Drawing.Size(311, 32);
            this.total_paid.TabIndex = 111;
            // 
            // payment_method
            // 
            this.payment_method.Animated = true;
            this.payment_method.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.payment_method, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.payment_method, BunifuAnimatorNS.DecorationType.None);
            this.payment_method.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment_method.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.payment_method.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payment_method.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payment_method.FocusedState.Parent = this.payment_method;
            this.payment_method.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.payment_method.ForeColor = System.Drawing.Color.White;
            this.payment_method.HoverState.Parent = this.payment_method;
            this.payment_method.ItemHeight = 30;
            this.payment_method.Items.AddRange(new object[] {
            " Choose Method",
            " Cash ",
            " Visa ",
            " Wallet"});
            this.payment_method.ItemsAppearance.Parent = this.payment_method;
            this.payment_method.Location = new System.Drawing.Point(256, 571);
            this.payment_method.Name = "payment_method";
            this.payment_method.ShadowDecoration.Parent = this.payment_method;
            this.payment_method.Size = new System.Drawing.Size(263, 36);
            this.payment_method.TabIndex = 110;
            // 
            // date
            // 
            this.date.BorderRadius = 5;
            this.date.Checked = true;
            this.date.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.date.CheckedState.Parent = this.date;
            this.logoAnimator.SetDecoration(this.date, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.panelAnimator.SetDecoration(this.date, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.date.FillColor = System.Drawing.Color.DarkSlateGray;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(719, 31);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(314, 36);
            this.date.TabIndex = 109;
            this.date.Value = new System.DateTime(2020, 7, 24, 18, 24, 36, 104);
            // 
            // branch
            // 
            this.branch.Animated = true;
            this.branch.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.branch, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.branch, BunifuAnimatorNS.DecorationType.None);
            this.branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.branch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.branch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.branch.FocusedState.Parent = this.branch;
            this.branch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.branch.ForeColor = System.Drawing.Color.White;
            this.branch.HoverState.Parent = this.branch;
            this.branch.IntegralHeight = false;
            this.branch.ItemHeight = 30;
            this.branch.Items.AddRange(new object[] {
            " Choose Your Branch",
            " Korba",
            " Nasr City",
            " Mohandseen"});
            this.branch.ItemsAppearance.Parent = this.branch;
            this.branch.Location = new System.Drawing.Point(256, 490);
            this.branch.Name = "branch";
            this.branch.ShadowDecoration.Parent = this.branch;
            this.branch.Size = new System.Drawing.Size(263, 36);
            this.branch.TabIndex = 108;
            // 
            // timing
            // 
            this.timing.Animated = true;
            this.timing.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.timing, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.timing, BunifuAnimatorNS.DecorationType.None);
            this.timing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.timing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.timing.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timing.FocusedState.Parent = this.timing;
            this.timing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timing.ForeColor = System.Drawing.Color.White;
            this.timing.HoverState.Parent = this.timing;
            this.timing.IntegralHeight = false;
            this.timing.ItemHeight = 30;
            this.timing.Items.AddRange(new object[] {
            "Selecet Time",
            "12:00AM",
            "11:30AM",
            "11:00AM",
            "10:30AM",
            "10:00AM",
            "9:30AM",
            "9:00AM",
            "8:30AM",
            "8:00AM",
            "7:30AM",
            "7:00AM",
            "6:30AM",
            "6:00AM",
            "5:30AM",
            "5:00AM",
            "4:30AM",
            "4:00AM",
            "3:30AM",
            "3:00AM",
            "2:30AM",
            "2:00AM",
            "1:30AM",
            "1:00AM",
            "12:00PM",
            "11:30PM",
            "11:00PM",
            "10:30PM",
            "10:00PM",
            "9:30PM",
            "9:00PM",
            "8:30PM",
            "8:00PM",
            "7:30PM",
            "7:00PM",
            "6:30PM",
            "6:00PM",
            "5:30PM",
            "5:00PM",
            "4:30PM",
            "4:00PM",
            "3:30PM",
            "3:00PM",
            "2:30PM",
            "2:00PM",
            "1:30PM",
            "1:00PM"});
            this.timing.ItemsAppearance.Parent = this.timing;
            this.timing.Location = new System.Drawing.Point(256, 402);
            this.timing.Name = "timing";
            this.timing.ShadowDecoration.Parent = this.timing;
            this.timing.Size = new System.Drawing.Size(263, 36);
            this.timing.TabIndex = 107;
            // 
            // body
            // 
            this.body.Animated = true;
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.body, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.body, BunifuAnimatorNS.DecorationType.None);
            this.body.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.body.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.FocusedState.Parent = this.body;
            this.body.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.body.ForeColor = System.Drawing.Color.White;
            this.body.HoverState.Parent = this.body;
            this.body.ItemHeight = 30;
            this.body.Items.AddRange(new object[] {
            " Choose Your Session",
            " Hydrofacial",
            " Capitation",
            " Cavitation",
            " No Session"});
            this.body.ItemsAppearance.Parent = this.body;
            this.body.Location = new System.Drawing.Point(256, 309);
            this.body.Name = "body";
            this.body.ShadowDecoration.Parent = this.body;
            this.body.Size = new System.Drawing.Size(263, 36);
            this.body.TabIndex = 106;
            // 
            // kind
            // 
            this.kind.Animated = true;
            this.kind.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.kind, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.kind, BunifuAnimatorNS.DecorationType.None);
            this.kind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.kind.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kind.FocusedState.Parent = this.kind;
            this.kind.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kind.ForeColor = System.Drawing.Color.White;
            this.kind.HoverState.Parent = this.kind;
            this.kind.ItemHeight = 30;
            this.kind.Items.AddRange(new object[] {
            " Choose Your Device",
            "  Laser",
            "  Deka",
            "  Candela",
            "  No Device"});
            this.kind.ItemsAppearance.Parent = this.kind;
            this.kind.Location = new System.Drawing.Point(256, 219);
            this.kind.Name = "kind";
            this.kind.ShadowDecoration.Parent = this.kind;
            this.kind.Size = new System.Drawing.Size(263, 36);
            this.kind.TabIndex = 105;
            // 
            // TableA
            // 
            this.TableA.AllowUserToAddRows = false;
            this.TableA.AllowUserToDeleteRows = false;
            this.TableA.AllowUserToResizeColumns = false;
            this.TableA.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.TableA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TableA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TableA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TableA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logoAnimator.SetDecoration(this.TableA, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.TableA, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableA.DefaultCellStyle = dataGridViewCellStyle6;
            this.TableA.EnableHeadersVisualStyles = false;
            this.TableA.GridColor = System.Drawing.Color.Gray;
            this.TableA.Location = new System.Drawing.Point(563, 108);
            this.TableA.Name = "TableA";
            this.TableA.ReadOnly = true;
            this.TableA.RowHeadersVisible = false;
            this.TableA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableA.Size = new System.Drawing.Size(505, 288);
            this.TableA.TabIndex = 104;
            this.TableA.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.TableA.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.TableA.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TableA.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TableA.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TableA.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TableA.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TableA.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.TableA.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TableA.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableA.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableA.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TableA.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableA.ThemeStyle.HeaderStyle.Height = 23;
            this.TableA.ThemeStyle.ReadOnly = true;
            this.TableA.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TableA.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableA.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableA.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.TableA.ThemeStyle.RowsStyle.Height = 22;
            this.TableA.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.TableA.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.TableA, "View Schedule of Doctor");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 102;
            this.label5.Text = "Branch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(56, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 32);
            this.label13.TabIndex = 87;
            this.label13.Text = "Payment Method";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(90, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 32);
            this.label10.TabIndex = 82;
            this.label10.Text = "Choose Time ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 32);
            this.label9.TabIndex = 81;
            this.label9.Text = "Session Types";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoAnimator.SetDecoration(this.phone, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.phone, BunifuAnimatorNS.DecorationType.None);
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(256, 120);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(263, 32);
            this.phone.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 32);
            this.label8.TabIndex = 79;
            this.label8.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(557, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 75;
            this.label6.Text = "Booking Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 71;
            this.label4.Text = "Device Type";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoAnimator.SetDecoration(this.name, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.name, BunifuAnimatorNS.DecorationType.None);
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(256, 31);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(263, 32);
            this.name.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Patient Name";
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.logoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation3;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation4;
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.slideMenu);
            this.Controls.Add(this.header);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.doctor_control_FormClosed);
            this.Load += new System.EventHandler(this.doctor_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.slideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btmMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.loader.ResumeLayout(false);
            this.loader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.Timer tm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel slideMenu;
        private Bunifu.Framework.UI.BunifuImageButton btmMenu;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.Animator panelAnimator;
        private BunifuAnimatorNS.Animator logoAnimator;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton show;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView TableA;
        private Guna.UI2.WinForms.Guna2ComboBox kind;
        private Guna.UI2.WinForms.Guna2ComboBox body;
        private Guna.UI2.WinForms.Guna2ComboBox timing;
        private Guna.UI2.WinForms.Guna2ComboBox branch;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private Guna.UI2.WinForms.Guna2ComboBox payment_method;
        private System.Windows.Forms.TextBox total_paid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox left;
        private Guna.UI2.WinForms.Guna2ComboBox source;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel loader;
        private System.Windows.Forms.Button calc;

    }
}