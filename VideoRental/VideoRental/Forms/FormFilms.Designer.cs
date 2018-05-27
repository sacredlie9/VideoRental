namespace VideoRental.Forms
{
    partial class FormFilms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilms));
            this.tabControlFilms = new System.Windows.Forms.TabControl();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.panelFilmStatistics = new System.Windows.Forms.Panel();
            this.buttonFilmNew = new System.Windows.Forms.Button();
            this.buttonFilmClear = new System.Windows.Forms.Button();
            this.buttonFilmPopular = new System.Windows.Forms.Button();
            this.textBoxFilmYear = new System.Windows.Forms.TextBox();
            this.textBoxFilmGenre = new System.Windows.Forms.TextBox();
            this.textBoxFilmProducer = new System.Windows.Forms.TextBox();
            this.textBoxFilmTitle = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabPageProducer = new System.Windows.Forms.TabPage();
            this.dataGridViewProducers = new System.Windows.Forms.DataGridView();
            this.panelProducerStatistics = new System.Windows.Forms.Panel();
            this.buttonProducerClear = new System.Windows.Forms.Button();
            this.textBoxProducerCountry = new System.Windows.Forms.TextBox();
            this.textBoxProducerBirthday = new System.Windows.Forms.TextBox();
            this.textBoxProducerName = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPageСartridge = new System.Windows.Forms.TabPage();
            this.dataGridViewCartridges = new System.Windows.Forms.DataGridView();
            this.panelCartridgeStatistics = new System.Windows.Forms.Panel();
            this.buttonPriceMax = new System.Windows.Forms.Button();
            this.buttonPriceMin = new System.Windows.Forms.Button();
            this.buttonCartridgeClear = new System.Windows.Forms.Button();
            this.textBoxCartridgePriceBefore = new System.Windows.Forms.TextBox();
            this.textBoxCartridgePriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxСartridgeFilm = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tabControlFilms.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.panelFilmStatistics.SuspendLayout();
            this.tabPageProducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).BeginInit();
            this.panelProducerStatistics.SuspendLayout();
            this.tabPageСartridge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartridges)).BeginInit();
            this.panelCartridgeStatistics.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFilms
            // 
            this.tabControlFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlFilms.Controls.Add(this.tabPageFilms);
            this.tabControlFilms.Controls.Add(this.tabPageProducer);
            this.tabControlFilms.Controls.Add(this.tabPageСartridge);
            this.tabControlFilms.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlFilms.HotTrack = true;
            this.tabControlFilms.Location = new System.Drawing.Point(12, 12);
            this.tabControlFilms.Name = "tabControlFilms";
            this.tabControlFilms.SelectedIndex = 0;
            this.tabControlFilms.Size = new System.Drawing.Size(1176, 500);
            this.tabControlFilms.TabIndex = 0;
            this.tabControlFilms.TabStop = false;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.BackColor = System.Drawing.Color.White;
            this.tabPageFilms.Controls.Add(this.dataGridViewFilms);
            this.tabPageFilms.Controls.Add(this.panelFilmStatistics);
            this.tabPageFilms.Controls.Add(this.textBoxFilmYear);
            this.tabPageFilms.Controls.Add(this.textBoxFilmGenre);
            this.tabPageFilms.Controls.Add(this.textBoxFilmProducer);
            this.tabPageFilms.Controls.Add(this.textBoxFilmTitle);
            this.tabPageFilms.Controls.Add(this.splitter2);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 41);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilms.Size = new System.Drawing.Size(1168, 455);
            this.tabPageFilms.TabIndex = 0;
            this.tabPageFilms.Text = "Фильмы";
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFilms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFilms.Location = new System.Drawing.Point(3, 133);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilms.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFilms.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewFilms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFilms.Size = new System.Drawing.Size(1162, 319);
            this.dataGridViewFilms.TabIndex = 0;
            this.dataGridViewFilms.TabStop = false;
            this.dataGridViewFilms.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // panelFilmStatistics
            // 
            this.panelFilmStatistics.Controls.Add(this.buttonFilmNew);
            this.panelFilmStatistics.Controls.Add(this.buttonFilmClear);
            this.panelFilmStatistics.Controls.Add(this.buttonFilmPopular);
            this.panelFilmStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilmStatistics.Location = new System.Drawing.Point(3, 73);
            this.panelFilmStatistics.Name = "panelFilmStatistics";
            this.panelFilmStatistics.Size = new System.Drawing.Size(1162, 60);
            this.panelFilmStatistics.TabIndex = 11;
            // 
            // buttonFilmNew
            // 
            this.buttonFilmNew.AutoSize = true;
            this.buttonFilmNew.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilmNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFilmNew.FlatAppearance.BorderSize = 0;
            this.buttonFilmNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonFilmNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonFilmNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilmNew.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilmNew.ForeColor = System.Drawing.Color.Black;
            this.buttonFilmNew.Location = new System.Drawing.Point(200, 0);
            this.buttonFilmNew.Name = "buttonFilmNew";
            this.buttonFilmNew.Size = new System.Drawing.Size(200, 60);
            this.buttonFilmNew.TabIndex = 2;
            this.buttonFilmNew.TabStop = false;
            this.buttonFilmNew.Text = "Новые";
            this.buttonFilmNew.UseMnemonic = false;
            this.buttonFilmNew.UseVisualStyleBackColor = false;
            this.buttonFilmNew.Click += new System.EventHandler(this.buttonFilmNew_Click);
            // 
            // buttonFilmClear
            // 
            this.buttonFilmClear.AutoSize = true;
            this.buttonFilmClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilmClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFilmClear.FlatAppearance.BorderSize = 0;
            this.buttonFilmClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonFilmClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonFilmClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilmClear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilmClear.ForeColor = System.Drawing.Color.Black;
            this.buttonFilmClear.Location = new System.Drawing.Point(962, 0);
            this.buttonFilmClear.Name = "buttonFilmClear";
            this.buttonFilmClear.Size = new System.Drawing.Size(200, 60);
            this.buttonFilmClear.TabIndex = 0;
            this.buttonFilmClear.TabStop = false;
            this.buttonFilmClear.Text = "Очистить";
            this.buttonFilmClear.UseMnemonic = false;
            this.buttonFilmClear.UseVisualStyleBackColor = false;
            this.buttonFilmClear.Visible = false;
            this.buttonFilmClear.Click += new System.EventHandler(this.buttonFilmClear_Click);
            // 
            // buttonFilmPopular
            // 
            this.buttonFilmPopular.AutoSize = true;
            this.buttonFilmPopular.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilmPopular.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFilmPopular.FlatAppearance.BorderSize = 0;
            this.buttonFilmPopular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonFilmPopular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonFilmPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilmPopular.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilmPopular.ForeColor = System.Drawing.Color.Black;
            this.buttonFilmPopular.Location = new System.Drawing.Point(0, 0);
            this.buttonFilmPopular.Name = "buttonFilmPopular";
            this.buttonFilmPopular.Size = new System.Drawing.Size(200, 60);
            this.buttonFilmPopular.TabIndex = 1;
            this.buttonFilmPopular.TabStop = false;
            this.buttonFilmPopular.Text = "Популярные";
            this.buttonFilmPopular.UseMnemonic = false;
            this.buttonFilmPopular.UseVisualStyleBackColor = false;
            this.buttonFilmPopular.Click += new System.EventHandler(this.buttonFilmPopular_Click);
            // 
            // textBoxFilmYear
            // 
            this.textBoxFilmYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilmYear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmYear.Location = new System.Drawing.Point(894, 17);
            this.textBoxFilmYear.MaxLength = 30;
            this.textBoxFilmYear.Name = "textBoxFilmYear";
            this.textBoxFilmYear.Size = new System.Drawing.Size(290, 41);
            this.textBoxFilmYear.TabIndex = 3;
            this.textBoxFilmYear.Click += new System.EventHandler(this.textBoxFilmFind_Click);
            this.textBoxFilmYear.TextChanged += new System.EventHandler(this.textBoxFilmFind_TextChanged);
            this.textBoxFilmYear.Enter += new System.EventHandler(this.textBoxFilmFind_Enter);
            this.textBoxFilmYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmFind_KeyPress);
            this.textBoxFilmYear.Leave += new System.EventHandler(this.textBoxFilmFind_Leave);
            // 
            // textBoxFilmGenre
            // 
            this.textBoxFilmGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilmGenre.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmGenre.Location = new System.Drawing.Point(302, 17);
            this.textBoxFilmGenre.MaxLength = 30;
            this.textBoxFilmGenre.Name = "textBoxFilmGenre";
            this.textBoxFilmGenre.Size = new System.Drawing.Size(290, 41);
            this.textBoxFilmGenre.TabIndex = 2;
            this.textBoxFilmGenre.Click += new System.EventHandler(this.textBoxFilmFind_Click);
            this.textBoxFilmGenre.TextChanged += new System.EventHandler(this.textBoxFilmFind_TextChanged);
            this.textBoxFilmGenre.Enter += new System.EventHandler(this.textBoxFilmFind_Enter);
            this.textBoxFilmGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmFind_KeyPress);
            this.textBoxFilmGenre.Leave += new System.EventHandler(this.textBoxFilmFind_Leave);
            // 
            // textBoxFilmProducer
            // 
            this.textBoxFilmProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilmProducer.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmProducer.Location = new System.Drawing.Point(598, 17);
            this.textBoxFilmProducer.MaxLength = 30;
            this.textBoxFilmProducer.Name = "textBoxFilmProducer";
            this.textBoxFilmProducer.Size = new System.Drawing.Size(290, 41);
            this.textBoxFilmProducer.TabIndex = 1;
            this.textBoxFilmProducer.Click += new System.EventHandler(this.textBoxFilmFind_Click);
            this.textBoxFilmProducer.TextChanged += new System.EventHandler(this.textBoxFilmFind_TextChanged);
            this.textBoxFilmProducer.Enter += new System.EventHandler(this.textBoxFilmFind_Enter);
            this.textBoxFilmProducer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmFind_KeyPress);
            this.textBoxFilmProducer.Leave += new System.EventHandler(this.textBoxFilmFind_Leave);
            // 
            // textBoxFilmTitle
            // 
            this.textBoxFilmTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilmTitle.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmTitle.Location = new System.Drawing.Point(6, 17);
            this.textBoxFilmTitle.MaxLength = 30;
            this.textBoxFilmTitle.Name = "textBoxFilmTitle";
            this.textBoxFilmTitle.Size = new System.Drawing.Size(290, 41);
            this.textBoxFilmTitle.TabIndex = 0;
            this.textBoxFilmTitle.Click += new System.EventHandler(this.textBoxFilmFind_Click);
            this.textBoxFilmTitle.TextChanged += new System.EventHandler(this.textBoxFilmFind_TextChanged);
            this.textBoxFilmTitle.Enter += new System.EventHandler(this.textBoxFilmFind_Enter);
            this.textBoxFilmTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmFind_KeyPress);
            this.textBoxFilmTitle.Leave += new System.EventHandler(this.textBoxFilmFind_Leave);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1162, 70);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // tabPageProducer
            // 
            this.tabPageProducer.Controls.Add(this.dataGridViewProducers);
            this.tabPageProducer.Controls.Add(this.panelProducerStatistics);
            this.tabPageProducer.Controls.Add(this.textBoxProducerCountry);
            this.tabPageProducer.Controls.Add(this.textBoxProducerBirthday);
            this.tabPageProducer.Controls.Add(this.textBoxProducerName);
            this.tabPageProducer.Controls.Add(this.splitter1);
            this.tabPageProducer.Location = new System.Drawing.Point(4, 41);
            this.tabPageProducer.Name = "tabPageProducer";
            this.tabPageProducer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducer.Size = new System.Drawing.Size(1168, 455);
            this.tabPageProducer.TabIndex = 1;
            this.tabPageProducer.Text = "Режиссеры";
            this.tabPageProducer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducers
            // 
            this.dataGridViewProducers.AllowUserToAddRows = false;
            this.dataGridViewProducers.AllowUserToDeleteRows = false;
            this.dataGridViewProducers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProducers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducers.Location = new System.Drawing.Point(3, 133);
            this.dataGridViewProducers.Name = "dataGridViewProducers";
            this.dataGridViewProducers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProducers.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewProducers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProducers.Size = new System.Drawing.Size(1162, 319);
            this.dataGridViewProducers.TabIndex = 0;
            this.dataGridViewProducers.TabStop = false;
            this.dataGridViewProducers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // panelProducerStatistics
            // 
            this.panelProducerStatistics.Controls.Add(this.buttonProducerClear);
            this.panelProducerStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducerStatistics.Location = new System.Drawing.Point(3, 73);
            this.panelProducerStatistics.Name = "panelProducerStatistics";
            this.panelProducerStatistics.Size = new System.Drawing.Size(1162, 60);
            this.panelProducerStatistics.TabIndex = 11;
            // 
            // buttonProducerClear
            // 
            this.buttonProducerClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonProducerClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonProducerClear.FlatAppearance.BorderSize = 0;
            this.buttonProducerClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonProducerClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonProducerClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducerClear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducerClear.Location = new System.Drawing.Point(962, 0);
            this.buttonProducerClear.Name = "buttonProducerClear";
            this.buttonProducerClear.Size = new System.Drawing.Size(200, 60);
            this.buttonProducerClear.TabIndex = 0;
            this.buttonProducerClear.TabStop = false;
            this.buttonProducerClear.Text = "Очистить";
            this.buttonProducerClear.UseMnemonic = false;
            this.buttonProducerClear.UseVisualStyleBackColor = false;
            this.buttonProducerClear.Visible = false;
            this.buttonProducerClear.Click += new System.EventHandler(this.buttonProducerClear_Click);
            // 
            // textBoxProducerCountry
            // 
            this.textBoxProducerCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxProducerCountry.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducerCountry.Location = new System.Drawing.Point(818, 17);
            this.textBoxProducerCountry.MaxLength = 30;
            this.textBoxProducerCountry.Name = "textBoxProducerCountry";
            this.textBoxProducerCountry.Size = new System.Drawing.Size(400, 41);
            this.textBoxProducerCountry.TabIndex = 2;
            this.textBoxProducerCountry.Click += new System.EventHandler(this.textBoxProducerFind_Click);
            this.textBoxProducerCountry.TextChanged += new System.EventHandler(this.textBoxProducerFind_TextChanged);
            this.textBoxProducerCountry.Enter += new System.EventHandler(this.textBoxProducerFind_Enter);
            this.textBoxProducerCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducerFind_KeyPress);
            this.textBoxProducerCountry.Leave += new System.EventHandler(this.textBoxProducerFind_Leave);
            // 
            // textBoxProducerBirthday
            // 
            this.textBoxProducerBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxProducerBirthday.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducerBirthday.Location = new System.Drawing.Point(412, 17);
            this.textBoxProducerBirthday.MaxLength = 30;
            this.textBoxProducerBirthday.Name = "textBoxProducerBirthday";
            this.textBoxProducerBirthday.Size = new System.Drawing.Size(400, 41);
            this.textBoxProducerBirthday.TabIndex = 1;
            this.textBoxProducerBirthday.Click += new System.EventHandler(this.textBoxProducerFind_Click);
            this.textBoxProducerBirthday.TextChanged += new System.EventHandler(this.textBoxProducerFind_TextChanged);
            this.textBoxProducerBirthday.Enter += new System.EventHandler(this.textBoxProducerFind_Enter);
            this.textBoxProducerBirthday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducerFind_KeyPress);
            this.textBoxProducerBirthday.Leave += new System.EventHandler(this.textBoxProducerFind_Leave);
            // 
            // textBoxProducerName
            // 
            this.textBoxProducerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxProducerName.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducerName.Location = new System.Drawing.Point(6, 17);
            this.textBoxProducerName.MaxLength = 30;
            this.textBoxProducerName.Name = "textBoxProducerName";
            this.textBoxProducerName.Size = new System.Drawing.Size(400, 41);
            this.textBoxProducerName.TabIndex = 0;
            this.textBoxProducerName.Click += new System.EventHandler(this.textBoxProducerFind_Click);
            this.textBoxProducerName.TextChanged += new System.EventHandler(this.textBoxProducerFind_TextChanged);
            this.textBoxProducerName.Enter += new System.EventHandler(this.textBoxProducerFind_Enter);
            this.textBoxProducerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducerFind_KeyPress);
            this.textBoxProducerName.Leave += new System.EventHandler(this.textBoxProducerFind_Leave);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1162, 70);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPageСartridge
            // 
            this.tabPageСartridge.Controls.Add(this.dataGridViewCartridges);
            this.tabPageСartridge.Controls.Add(this.panelCartridgeStatistics);
            this.tabPageСartridge.Controls.Add(this.textBoxCartridgePriceBefore);
            this.tabPageСartridge.Controls.Add(this.textBoxCartridgePriceFrom);
            this.tabPageСartridge.Controls.Add(this.textBoxСartridgeFilm);
            this.tabPageСartridge.Controls.Add(this.splitter3);
            this.tabPageСartridge.Location = new System.Drawing.Point(4, 41);
            this.tabPageСartridge.Name = "tabPageСartridge";
            this.tabPageСartridge.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageСartridge.Size = new System.Drawing.Size(1168, 455);
            this.tabPageСartridge.TabIndex = 2;
            this.tabPageСartridge.Text = "Касcеты";
            this.tabPageСartridge.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCartridges
            // 
            this.dataGridViewCartridges.AllowUserToAddRows = false;
            this.dataGridViewCartridges.AllowUserToDeleteRows = false;
            this.dataGridViewCartridges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCartridges.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCartridges.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCartridges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCartridges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartridges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCartridges.Location = new System.Drawing.Point(3, 133);
            this.dataGridViewCartridges.Name = "dataGridViewCartridges";
            this.dataGridViewCartridges.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCartridges.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCartridges.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewCartridges.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCartridges.Size = new System.Drawing.Size(1162, 319);
            this.dataGridViewCartridges.TabIndex = 0;
            this.dataGridViewCartridges.TabStop = false;
            this.dataGridViewCartridges.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // panelCartridgeStatistics
            // 
            this.panelCartridgeStatistics.Controls.Add(this.buttonPriceMax);
            this.panelCartridgeStatistics.Controls.Add(this.buttonPriceMin);
            this.panelCartridgeStatistics.Controls.Add(this.buttonCartridgeClear);
            this.panelCartridgeStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCartridgeStatistics.Location = new System.Drawing.Point(3, 73);
            this.panelCartridgeStatistics.Name = "panelCartridgeStatistics";
            this.panelCartridgeStatistics.Size = new System.Drawing.Size(1162, 60);
            this.panelCartridgeStatistics.TabIndex = 10;
            // 
            // buttonPriceMax
            // 
            this.buttonPriceMax.AutoSize = true;
            this.buttonPriceMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonPriceMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPriceMax.FlatAppearance.BorderSize = 0;
            this.buttonPriceMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonPriceMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonPriceMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriceMax.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriceMax.ForeColor = System.Drawing.Color.Black;
            this.buttonPriceMax.Location = new System.Drawing.Point(200, 0);
            this.buttonPriceMax.Name = "buttonPriceMax";
            this.buttonPriceMax.Size = new System.Drawing.Size(200, 60);
            this.buttonPriceMax.TabIndex = 3;
            this.buttonPriceMax.TabStop = false;
            this.buttonPriceMax.Text = "Дорогие";
            this.buttonPriceMax.UseMnemonic = false;
            this.buttonPriceMax.UseVisualStyleBackColor = false;
            this.buttonPriceMax.Click += new System.EventHandler(this.buttonPriceMax_Click);
            // 
            // buttonPriceMin
            // 
            this.buttonPriceMin.AutoSize = true;
            this.buttonPriceMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonPriceMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPriceMin.FlatAppearance.BorderSize = 0;
            this.buttonPriceMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonPriceMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonPriceMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriceMin.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriceMin.ForeColor = System.Drawing.Color.Black;
            this.buttonPriceMin.Location = new System.Drawing.Point(0, 0);
            this.buttonPriceMin.Name = "buttonPriceMin";
            this.buttonPriceMin.Size = new System.Drawing.Size(200, 60);
            this.buttonPriceMin.TabIndex = 2;
            this.buttonPriceMin.TabStop = false;
            this.buttonPriceMin.Text = "Дешевые";
            this.buttonPriceMin.UseMnemonic = false;
            this.buttonPriceMin.UseVisualStyleBackColor = false;
            this.buttonPriceMin.Click += new System.EventHandler(this.buttonPriceMin_Click);
            // 
            // buttonCartridgeClear
            // 
            this.buttonCartridgeClear.AutoSize = true;
            this.buttonCartridgeClear.BackColor = System.Drawing.Color.White;
            this.buttonCartridgeClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCartridgeClear.FlatAppearance.BorderSize = 0;
            this.buttonCartridgeClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonCartridgeClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonCartridgeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartridgeClear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonCartridgeClear.Location = new System.Drawing.Point(962, 0);
            this.buttonCartridgeClear.Name = "buttonCartridgeClear";
            this.buttonCartridgeClear.Size = new System.Drawing.Size(200, 60);
            this.buttonCartridgeClear.TabIndex = 0;
            this.buttonCartridgeClear.TabStop = false;
            this.buttonCartridgeClear.Text = "Очистить";
            this.buttonCartridgeClear.UseMnemonic = false;
            this.buttonCartridgeClear.UseVisualStyleBackColor = false;
            this.buttonCartridgeClear.Visible = false;
            this.buttonCartridgeClear.Click += new System.EventHandler(this.buttonСartridgeClear_Click);
            // 
            // textBoxCartridgePriceBefore
            // 
            this.textBoxCartridgePriceBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCartridgePriceBefore.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCartridgePriceBefore.Location = new System.Drawing.Point(818, 17);
            this.textBoxCartridgePriceBefore.MaxLength = 30;
            this.textBoxCartridgePriceBefore.Name = "textBoxCartridgePriceBefore";
            this.textBoxCartridgePriceBefore.Size = new System.Drawing.Size(400, 41);
            this.textBoxCartridgePriceBefore.TabIndex = 2;
            this.textBoxCartridgePriceBefore.Click += new System.EventHandler(this.textBoxСartridgeFind_Click);
            this.textBoxCartridgePriceBefore.TextChanged += new System.EventHandler(this.textBoxСartridgeFind_TextChanged);
            this.textBoxCartridgePriceBefore.Enter += new System.EventHandler(this.textBoxCartridgeFind_Enter);
            this.textBoxCartridgePriceBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxСartridgeFind_KeyPress);
            this.textBoxCartridgePriceBefore.Leave += new System.EventHandler(this.textBoxСartridgeFind_Leave);
            // 
            // textBoxCartridgePriceFrom
            // 
            this.textBoxCartridgePriceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCartridgePriceFrom.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCartridgePriceFrom.Location = new System.Drawing.Point(412, 17);
            this.textBoxCartridgePriceFrom.MaxLength = 30;
            this.textBoxCartridgePriceFrom.Name = "textBoxCartridgePriceFrom";
            this.textBoxCartridgePriceFrom.Size = new System.Drawing.Size(400, 41);
            this.textBoxCartridgePriceFrom.TabIndex = 1;
            this.textBoxCartridgePriceFrom.Click += new System.EventHandler(this.textBoxСartridgeFind_Click);
            this.textBoxCartridgePriceFrom.TextChanged += new System.EventHandler(this.textBoxСartridgeFind_TextChanged);
            this.textBoxCartridgePriceFrom.Enter += new System.EventHandler(this.textBoxCartridgeFind_Enter);
            this.textBoxCartridgePriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxСartridgeFind_KeyPress);
            this.textBoxCartridgePriceFrom.Leave += new System.EventHandler(this.textBoxСartridgeFind_Leave);
            // 
            // textBoxСartridgeFilm
            // 
            this.textBoxСartridgeFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxСartridgeFilm.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxСartridgeFilm.Location = new System.Drawing.Point(6, 17);
            this.textBoxСartridgeFilm.MaxLength = 30;
            this.textBoxСartridgeFilm.Name = "textBoxСartridgeFilm";
            this.textBoxСartridgeFilm.Size = new System.Drawing.Size(400, 41);
            this.textBoxСartridgeFilm.TabIndex = 0;
            this.textBoxСartridgeFilm.Click += new System.EventHandler(this.textBoxСartridgeFind_Click);
            this.textBoxСartridgeFilm.TextChanged += new System.EventHandler(this.textBoxСartridgeFind_TextChanged);
            this.textBoxСartridgeFilm.Enter += new System.EventHandler(this.textBoxCartridgeFind_Enter);
            this.textBoxСartridgeFilm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxСartridgeFind_KeyPress);
            this.textBoxСartridgeFilm.Leave += new System.EventHandler(this.textBoxСartridgeFind_Leave);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.White;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(3, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1162, 70);
            this.splitter3.TabIndex = 9;
            this.splitter3.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemReport});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(174, 70);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemEdit.Text = "Редактировать";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemDelete.Text = "Удалить";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // toolStripMenuItemReport
            // 
            this.toolStripMenuItemReport.Name = "toolStripMenuItemReport";
            this.toolStripMenuItemReport.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemReport.Text = "Сохранить в файл";
            this.toolStripMenuItemReport.Click += new System.EventHandler(this.toolStripMenuItemReport_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(460, 518);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(280, 70);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseMnemonic = false;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(12, 518);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(280, 70);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseMnemonic = false;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(908, 518);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(280, 70);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControlFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormFilms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFilms_FormClosing);
            this.Load += new System.EventHandler(this.FormFilms_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFilms_KeyDown);
            this.tabControlFilms.ResumeLayout(false);
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageFilms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.panelFilmStatistics.ResumeLayout(false);
            this.panelFilmStatistics.PerformLayout();
            this.tabPageProducer.ResumeLayout(false);
            this.tabPageProducer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).EndInit();
            this.panelProducerStatistics.ResumeLayout(false);
            this.tabPageСartridge.ResumeLayout(false);
            this.tabPageСartridge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartridges)).EndInit();
            this.panelCartridgeStatistics.ResumeLayout(false);
            this.panelCartridgeStatistics.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFilms;
        private System.Windows.Forms.TabPage tabPageFilms;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Panel panelFilmStatistics;
        private System.Windows.Forms.Button buttonFilmNew;
        private System.Windows.Forms.Button buttonFilmClear;
        private System.Windows.Forms.Button buttonFilmPopular;
        private System.Windows.Forms.TextBox textBoxFilmYear;
        private System.Windows.Forms.TextBox textBoxFilmGenre;
        private System.Windows.Forms.TextBox textBoxFilmProducer;
        private System.Windows.Forms.TextBox textBoxFilmTitle;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabPage tabPageProducer;
        private System.Windows.Forms.DataGridView dataGridViewProducers;
        private System.Windows.Forms.Panel panelProducerStatistics;
        private System.Windows.Forms.Button buttonProducerClear;
        private System.Windows.Forms.TextBox textBoxProducerCountry;
        private System.Windows.Forms.TextBox textBoxProducerBirthday;
        private System.Windows.Forms.TextBox textBoxProducerName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPageСartridge;
        private System.Windows.Forms.DataGridView dataGridViewCartridges;
        private System.Windows.Forms.Panel panelCartridgeStatistics;
        private System.Windows.Forms.Button buttonPriceMax;
        private System.Windows.Forms.Button buttonPriceMin;
        private System.Windows.Forms.Button buttonCartridgeClear;
        private System.Windows.Forms.TextBox textBoxCartridgePriceBefore;
        private System.Windows.Forms.TextBox textBoxCartridgePriceFrom;
        private System.Windows.Forms.TextBox textBoxСartridgeFilm;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonBack;
    }
}