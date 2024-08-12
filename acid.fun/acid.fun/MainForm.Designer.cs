namespace acid.fun
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.menuEnabled = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.skyboxEnabled = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(900, 550);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "home-7-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 29);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(800, 411);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::acid.fun.Properties.Resources.bitdancer;
            this.pictureBox1.Location = new System.Drawing.Point(28, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.ImageKey = "picture-3-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Optimizations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.materialCard2);
            this.flowLayoutPanel1.Controls.Add(this.materialCard3);
            this.flowLayoutPanel1.Controls.Add(this.materialCard6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(886, 501);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.menuEnabled);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(194, 100);
            this.materialCard2.TabIndex = 1;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // menuEnabled
            // 
            this.menuEnabled.AutoResize = false;
            this.menuEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuEnabled.Depth = 0;
            this.menuEnabled.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.menuEnabled.DropDownHeight = 118;
            this.menuEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuEnabled.DropDownWidth = 121;
            this.menuEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.menuEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuEnabled.FormattingEnabled = true;
            this.menuEnabled.Hint = "False";
            this.menuEnabled.IntegralHeight = false;
            this.menuEnabled.ItemHeight = 29;
            this.menuEnabled.Items.AddRange(new object[] {
            "False",
            "True"});
            this.menuEnabled.Location = new System.Drawing.Point(22, 48);
            this.menuEnabled.MaxDropDownItems = 4;
            this.menuEnabled.MouseState = MaterialSkin.MouseState.OUT;
            this.menuEnabled.Name = "menuEnabled";
            this.menuEnabled.Size = new System.Drawing.Size(158, 35);
            this.menuEnabled.TabIndex = 2;
            this.menuEnabled.UseTallSize = false;
            this.menuEnabled.SelectedIndexChanged += new System.EventHandler(this.menuEnabled_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dark Textures";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.skyboxEnabled);
            this.materialCard3.Controls.Add(this.label4);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(236, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(194, 100);
            this.materialCard3.TabIndex = 4;
            // 
            // skyboxEnabled
            // 
            this.skyboxEnabled.AutoCompleteCustomSource.AddRange(new string[] {
            "Enabled",
            "Disabled"});
            this.skyboxEnabled.AutoResize = false;
            this.skyboxEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyboxEnabled.Depth = 0;
            this.skyboxEnabled.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.skyboxEnabled.DropDownHeight = 118;
            this.skyboxEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skyboxEnabled.DropDownWidth = 121;
            this.skyboxEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.skyboxEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyboxEnabled.FormattingEnabled = true;
            this.skyboxEnabled.Hint = "False";
            this.skyboxEnabled.IntegralHeight = false;
            this.skyboxEnabled.ItemHeight = 29;
            this.skyboxEnabled.Items.AddRange(new object[] {
            "False",
            "True"});
            this.skyboxEnabled.Location = new System.Drawing.Point(22, 48);
            this.skyboxEnabled.MaxDropDownItems = 4;
            this.skyboxEnabled.MouseState = MaterialSkin.MouseState.OUT;
            this.skyboxEnabled.Name = "skyboxEnabled";
            this.skyboxEnabled.Size = new System.Drawing.Size(158, 35);
            this.skyboxEnabled.TabIndex = 2;
            this.skyboxEnabled.UseTallSize = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enable Gray skybox";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialCard5);
            this.tabPage3.Controls.Add(this.materialCard4);
            this.tabPage3.ImageKey = "flag-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FFlags";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialButton1);
            this.materialCard4.Controls.Add(this.materialTextBox2);
            this.materialCard4.Controls.Add(this.label3);
            this.materialCard4.Controls.Add(this.materialTextBox1);
            this.materialCard4.Controls.Add(this.label1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(618, 191);
            this.materialCard4.TabIndex = 2;
            this.materialCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard4_Paint);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(18, 150);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Update";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox2.Location = new System.Drawing.Point(18, 105);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(322, 36);
            this.materialTextBox2.TabIndex = 4;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.UseTallSize = false;
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FFlag";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialCard7);
            this.tabPage4.ImageKey = "plus-8-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(892, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Crosshair";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home-7-32.png");
            this.imageList1.Images.SetKeyName(1, "flag-32.png");
            this.imageList1.Images.SetKeyName(2, "picture-3-32.png");
            this.imageList1.Images.SetKeyName(3, "settings-4-32.png");
            this.imageList1.Images.SetKeyName(4, "plus-8-32.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "FFlag";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox4.Location = new System.Drawing.Point(18, 42);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(322, 36);
            this.materialTextBox4.TabIndex = 2;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.UseTallSize = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(18, 87);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(80, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Remove";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialButton2);
            this.materialCard5.Controls.Add(this.materialTextBox4);
            this.materialCard5.Controls.Add(this.label6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 220);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(618, 136);
            this.materialCard5.TabIndex = 3;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(18, 42);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(322, 36);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialButton3);
            this.materialCard7.Controls.Add(this.materialComboBox1);
            this.materialCard7.Controls.Add(this.materialComboBox2);
            this.materialCard7.Controls.Add(this.label8);
            this.materialCard7.Controls.Add(this.materialButton4);
            this.materialCard7.Controls.Add(this.materialTextBox6);
            this.materialCard7.Controls.Add(this.label9);
            this.materialCard7.Controls.Add(this.label10);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 14);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(618, 263);
            this.materialCard7.TabIndex = 1004;
            this.materialCard7.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard7_Paint);
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 118;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 29;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Blue",
            "Green",
            "Cyan",
            "Purple"});
            this.materialComboBox2.Location = new System.Drawing.Point(22, 167);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(318, 35);
            this.materialComboBox2.TabIndex = 8;
            this.materialComboBox2.UseTallSize = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Color";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(18, 211);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 5;
            this.materialButton4.Text = "Show";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox6.Location = new System.Drawing.Point(22, 104);
            this.materialTextBox6.MaxLength = 2;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.ShortcutsEnabled = false;
            this.materialTextBox6.Size = new System.Drawing.Size(322, 36);
            this.materialTextBox6.TabIndex = 4;
            this.materialTextBox6.Text = "7";
            this.materialTextBox6.UseTallSize = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Crosshair Type";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Cross",
            "Dot"});
            this.materialComboBox1.Location = new System.Drawing.Point(22, 41);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(318, 35);
            this.materialComboBox1.TabIndex = 9;
            this.materialComboBox1.UseTallSize = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(90, 211);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(64, 36);
            this.materialButton3.TabIndex = 10;
            this.materialButton3.Text = "HIDE";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = true;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialComboBox3);
            this.materialCard6.Controls.Add(this.label5);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(458, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(194, 100);
            this.materialCard6.TabIndex = 5;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "Enabled",
            "Disabled"});
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 118;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "False";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 29;
            this.materialComboBox3.Items.AddRange(new object[] {
            "False",
            "True"});
            this.materialComboBox3.Location = new System.Drawing.Point(22, 48);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(158, 35);
            this.materialComboBox3.TabIndex = 2;
            this.materialComboBox3.UseTallSize = false;
            this.materialComboBox3.SelectedIndexChanged += new System.EventHandler(this.materialComboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minecraft Font";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acid.fun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox menuEnabled;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialComboBox skyboxEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private System.Windows.Forms.Label label5;
    }
}