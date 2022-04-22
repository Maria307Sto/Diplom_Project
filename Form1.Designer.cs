
namespace advertising
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.adventionCompanyesComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.importSave = new System.Windows.Forms.ToolStripButton();
            this.tbSaveFile = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Col11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.col14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orgSummaryDataGrid = new System.Windows.Forms.DataGridView();
            this.OrganizationIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_organiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgSummaryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.adventionCompanyesComboBox,
            this.toolStripButton1,
            this.toolStripButton2,
            this.importSave,
            this.tbSaveFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(185, 25);
            this.toolStripLabel1.Text = "Рекламная компания";
            // 
            // adventionCompanyesComboBox
            // 
            this.adventionCompanyesComboBox.Name = "adventionCompanyesComboBox";
            this.adventionCompanyesComboBox.Size = new System.Drawing.Size(200, 28);
            this.adventionCompanyesComboBox.SelectedIndexChanged += new System.EventHandler(this.adventionCompanyesComboBox_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Gray;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 25);
            this.toolStripButton1.Text = "Создать";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 25);
            this.toolStripButton2.Text = "Добавить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // importSave
            // 
            this.importSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importSave.ImageTransparentColor = System.Drawing.Color.Silver;
            this.importSave.Name = "importSave";
            this.importSave.Size = new System.Drawing.Size(69, 25);
            this.importSave.Text = "Экспорт";
            this.importSave.ToolTipText = "Импорт";
            this.importSave.Click += new System.EventHandler(this.importSave_Click);
            // 
            // tbSaveFile
            // 
            this.tbSaveFile.Name = "tbSaveFile";
            this.tbSaveFile.Size = new System.Drawing.Size(100, 28);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 607);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 306);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Компании";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 27);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(200, 166);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(205, 27);
            this.textBox10.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название организации";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(200, 122);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(205, 27);
            this.textBox9.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата создания";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(228, 82);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(177, 27);
            this.textBox8.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ИНН";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(200, 43);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(205, 27);
            this.textBox7.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Руководитель организации";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(510, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(243, 27);
            this.textBox6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер телефона";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(510, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Сайт";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(510, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ОГРН";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(510, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "ОКПО";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(510, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "БИК\\КПП";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контакты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col11,
            this.Col12,
            this.Col13});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1032, 259);
            this.dataGridView2.TabIndex = 0;
            // 
            // Col11
            // 
            this.Col11.HeaderText = "name_organization";
            this.Col11.MinimumWidth = 6;
            this.Col11.Name = "Col11";
            this.Col11.Width = 125;
            // 
            // Col12
            // 
            this.Col12.HeaderText = "number";
            this.Col12.MinimumWidth = 6;
            this.Col12.Name = "Col12";
            this.Col12.Width = 125;
            // 
            // Col13
            // 
            this.Col13.HeaderText = "supervizor";
            this.Col13.MinimumWidth = 6;
            this.Col13.Name = "Col13";
            this.Col13.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1038, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Звонки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col14,
            this.Col15,
            this.Col16,
            this.Col17,
            this.Col18,
            this.Col19,
            this.col20});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1032, 259);
            this.dataGridView3.TabIndex = 0;
            // 
            // col14
            // 
            this.col14.HeaderText = "calls_organization";
            this.col14.MinimumWidth = 6;
            this.col14.Name = "col14";
            this.col14.Width = 125;
            // 
            // Col15
            // 
            this.Col15.HeaderText = "numberTel1";
            this.Col15.MinimumWidth = 6;
            this.Col15.Name = "Col15";
            this.Col15.Width = 125;
            // 
            // Col16
            // 
            this.Col16.HeaderText = "numberTel2";
            this.Col16.MinimumWidth = 6;
            this.Col16.Name = "Col16";
            this.Col16.Width = 125;
            // 
            // Col17
            // 
            this.Col17.HeaderText = "e_mail";
            this.Col17.MinimumWidth = 6;
            this.Col17.Name = "Col17";
            this.Col17.Width = 125;
            // 
            // Col18
            // 
            this.Col18.HeaderText = "status";
            this.Col18.MinimumWidth = 6;
            this.Col18.Name = "Col18";
            this.Col18.Width = 125;
            // 
            // Col19
            // 
            this.Col19.HeaderText = "dateCalls";
            this.Col19.MinimumWidth = 6;
            this.Col19.Name = "Col19";
            this.Col19.Width = 125;
            // 
            // col20
            // 
            this.col20.HeaderText = "dateNext";
            this.col20.MinimumWidth = 6;
            this.col20.Name = "col20";
            this.col20.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.orgSummaryDataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 297);
            this.panel1.TabIndex = 1;
            // 
            // orgSummaryDataGrid
            // 
            this.orgSummaryDataGrid.AllowUserToAddRows = false;
            this.orgSummaryDataGrid.AllowUserToDeleteRows = false;
            this.orgSummaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgSummaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationIdColumn,
            this.name_organiz,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8,
            this.Col9,
            this.Col10});
            this.orgSummaryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgSummaryDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orgSummaryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.orgSummaryDataGrid.Name = "orgSummaryDataGrid";
            this.orgSummaryDataGrid.RowHeadersWidth = 51;
            this.orgSummaryDataGrid.RowTemplate.Height = 29;
            this.orgSummaryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orgSummaryDataGrid.Size = new System.Drawing.Size(1046, 297);
            this.orgSummaryDataGrid.TabIndex = 0;
            this.orgSummaryDataGrid.SelectionChanged += new System.EventHandler(this.orgSummaryDataGrid_SelectionChanged);
            // 
            // OrganizationIdColumn
            // 
            this.OrganizationIdColumn.HeaderText = "id";
            this.OrganizationIdColumn.MinimumWidth = 6;
            this.OrganizationIdColumn.Name = "OrganizationIdColumn";
            this.OrganizationIdColumn.Visible = false;
            this.OrganizationIdColumn.Width = 125;
            // 
            // name_organiz
            // 
            this.name_organiz.HeaderText = "name_organiz";
            this.name_organiz.MinimumWidth = 6;
            this.name_organiz.Name = "name_organiz";
            this.name_organiz.Width = 200;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "date";
            this.Col2.MinimumWidth = 6;
            this.Col2.Name = "Col2";
            this.Col2.Width = 125;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "inn";
            this.Col3.MinimumWidth = 6;
            this.Col3.Name = "Col3";
            this.Col3.Width = 125;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "supervizor";
            this.Col4.MinimumWidth = 6;
            this.Col4.Name = "Col4";
            this.Col4.Width = 200;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "number_tel";
            this.Col5.MinimumWidth = 6;
            this.Col5.Name = "Col5";
            this.Col5.Width = 125;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "address";
            this.Col6.MinimumWidth = 6;
            this.Col6.Name = "Col6";
            this.Col6.Width = 200;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "site";
            this.Col7.MinimumWidth = 6;
            this.Col7.Name = "Col7";
            this.Col7.Width = 150;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "ogrn";
            this.Col8.MinimumWidth = 6;
            this.Col8.Name = "Col8";
            this.Col8.Width = 125;
            // 
            // Col9
            // 
            this.Col9.HeaderText = "okpo";
            this.Col9.MinimumWidth = 6;
            this.Col9.Name = "Col9";
            this.Col9.Width = 125;
            // 
            // Col10
            // 
            this.Col10.HeaderText = "bik/kpp";
            this.Col10.MinimumWidth = 6;
            this.Col10.Name = "Col10";
            this.Col10.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Софт-Импэкс\"";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orgSummaryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox adventionCompanyesComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView orgSummaryDataGrid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col13;
        private System.Windows.Forms.DataGridViewTextBoxColumn col14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col19;
        private System.Windows.Forms.DataGridViewTextBoxColumn col20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton importSave;
        private System.Windows.Forms.ToolStripTextBox tbSaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_organiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col10;
    }
}

