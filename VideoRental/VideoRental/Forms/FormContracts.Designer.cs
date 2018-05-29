namespace VideoRental.Forms
{
    partial class FormContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContracts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxReturnByFact = new System.Windows.Forms.TextBox();
            this.textBoxReturn = new System.Windows.Forms.TextBox();
            this.textBoxReceiving = new System.Windows.Forms.TextBox();
            this.textBoxCartridge = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.panelClientStatistics = new System.Windows.Forms.Panel();
            this.buttonNotReturned = new System.Windows.Forms.Button();
            this.buttonInactive = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonActive = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.panelClientStatistics.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxReturnByFact);
            this.panel1.Controls.Add(this.textBoxReturn);
            this.panel1.Controls.Add(this.textBoxReceiving);
            this.panel1.Controls.Add(this.textBoxCartridge);
            this.panel1.Controls.Add(this.textBoxClient);
            this.panel1.Controls.Add(this.dgvContracts);
            this.panel1.Controls.Add(this.panelClientStatistics);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 500);
            this.panel1.TabIndex = 5;
            // 
            // textBoxReturnByFact
            // 
            this.textBoxReturnByFact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxReturnByFact.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReturnByFact.Location = new System.Drawing.Point(1070, 14);
            this.textBoxReturnByFact.MaxLength = 30;
            this.textBoxReturnByFact.Name = "textBoxReturnByFact";
            this.textBoxReturnByFact.Size = new System.Drawing.Size(260, 41);
            this.textBoxReturnByFact.TabIndex = 19;
            this.textBoxReturnByFact.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxReturnByFact.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxReturnByFact.Enter += new System.EventHandler(this.textBoxFind_Enter);
            this.textBoxReturnByFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            this.textBoxReturnByFact.Leave += new System.EventHandler(this.textBoxFind_Leave);
            // 
            // textBoxReturn
            // 
            this.textBoxReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxReturn.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReturn.Location = new System.Drawing.Point(804, 14);
            this.textBoxReturn.MaxLength = 30;
            this.textBoxReturn.Name = "textBoxReturn";
            this.textBoxReturn.Size = new System.Drawing.Size(260, 41);
            this.textBoxReturn.TabIndex = 18;
            this.textBoxReturn.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxReturn.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxReturn.Enter += new System.EventHandler(this.textBoxFind_Enter);
            this.textBoxReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            this.textBoxReturn.Leave += new System.EventHandler(this.textBoxFind_Leave);
            // 
            // textBoxReceiving
            // 
            this.textBoxReceiving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxReceiving.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReceiving.Location = new System.Drawing.Point(538, 14);
            this.textBoxReceiving.MaxLength = 30;
            this.textBoxReceiving.Name = "textBoxReceiving";
            this.textBoxReceiving.Size = new System.Drawing.Size(260, 41);
            this.textBoxReceiving.TabIndex = 17;
            this.textBoxReceiving.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxReceiving.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxReceiving.Enter += new System.EventHandler(this.textBoxFind_Enter);
            this.textBoxReceiving.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            this.textBoxReceiving.Leave += new System.EventHandler(this.textBoxFind_Leave);
            // 
            // textBoxCartridge
            // 
            this.textBoxCartridge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCartridge.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCartridge.Location = new System.Drawing.Point(272, 14);
            this.textBoxCartridge.MaxLength = 30;
            this.textBoxCartridge.Name = "textBoxCartridge";
            this.textBoxCartridge.Size = new System.Drawing.Size(260, 41);
            this.textBoxCartridge.TabIndex = 16;
            this.textBoxCartridge.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxCartridge.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxCartridge.Enter += new System.EventHandler(this.textBoxFind_Enter);
            this.textBoxCartridge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            this.textBoxCartridge.Leave += new System.EventHandler(this.textBoxFind_Leave);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClient.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClient.Location = new System.Drawing.Point(6, 14);
            this.textBoxClient.MaxLength = 30;
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(260, 41);
            this.textBoxClient.TabIndex = 15;
            this.textBoxClient.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxClient.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            this.textBoxClient.Enter += new System.EventHandler(this.textBoxFind_Enter);
            this.textBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFind_KeyPress);
            this.textBoxClient.Leave += new System.EventHandler(this.textBoxFind_Leave);
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvContracts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.Location = new System.Drawing.Point(0, 130);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvContracts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContracts.Size = new System.Drawing.Size(1176, 370);
            this.dgvContracts.TabIndex = 12;
            this.dgvContracts.TabStop = false;
            this.dgvContracts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContracts_CellMouseClick);
            // 
            // panelClientStatistics
            // 
            this.panelClientStatistics.Controls.Add(this.buttonNotReturned);
            this.panelClientStatistics.Controls.Add(this.buttonInactive);
            this.panelClientStatistics.Controls.Add(this.buttonClear);
            this.panelClientStatistics.Controls.Add(this.buttonActive);
            this.panelClientStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientStatistics.Location = new System.Drawing.Point(0, 70);
            this.panelClientStatistics.Name = "panelClientStatistics";
            this.panelClientStatistics.Size = new System.Drawing.Size(1176, 60);
            this.panelClientStatistics.TabIndex = 14;
            // 
            // buttonNotReturned
            // 
            this.buttonNotReturned.AutoSize = true;
            this.buttonNotReturned.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotReturned.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNotReturned.FlatAppearance.BorderSize = 0;
            this.buttonNotReturned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonNotReturned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonNotReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotReturned.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNotReturned.ForeColor = System.Drawing.Color.Black;
            this.buttonNotReturned.Location = new System.Drawing.Point(400, 0);
            this.buttonNotReturned.Name = "buttonNotReturned";
            this.buttonNotReturned.Size = new System.Drawing.Size(268, 60);
            this.buttonNotReturned.TabIndex = 2;
            this.buttonNotReturned.TabStop = false;
            this.buttonNotReturned.Text = "Не возвращенные";
            this.buttonNotReturned.UseMnemonic = false;
            this.buttonNotReturned.UseVisualStyleBackColor = false;
            this.buttonNotReturned.Visible = false;
            this.buttonNotReturned.Click += new System.EventHandler(this.buttonNotReturned_Click);
            // 
            // buttonInactive
            // 
            this.buttonInactive.AutoSize = true;
            this.buttonInactive.BackColor = System.Drawing.Color.Transparent;
            this.buttonInactive.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonInactive.FlatAppearance.BorderSize = 0;
            this.buttonInactive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonInactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInactive.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInactive.ForeColor = System.Drawing.Color.Black;
            this.buttonInactive.Location = new System.Drawing.Point(200, 0);
            this.buttonInactive.Name = "buttonInactive";
            this.buttonInactive.Size = new System.Drawing.Size(200, 60);
            this.buttonInactive.TabIndex = 3;
            this.buttonInactive.TabStop = false;
            this.buttonInactive.Text = "Неактивные";
            this.buttonInactive.UseMnemonic = false;
            this.buttonInactive.UseVisualStyleBackColor = false;
            this.buttonInactive.Click += new System.EventHandler(this.buttonInactive_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(976, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(200, 60);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseMnemonic = false;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonActive
            // 
            this.buttonActive.AutoSize = true;
            this.buttonActive.BackColor = System.Drawing.Color.Transparent;
            this.buttonActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonActive.FlatAppearance.BorderSize = 0;
            this.buttonActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActive.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActive.ForeColor = System.Drawing.Color.Black;
            this.buttonActive.Location = new System.Drawing.Point(0, 0);
            this.buttonActive.Name = "buttonActive";
            this.buttonActive.Size = new System.Drawing.Size(200, 60);
            this.buttonActive.TabIndex = 1;
            this.buttonActive.TabStop = false;
            this.buttonActive.Text = "Активные";
            this.buttonActive.UseMnemonic = false;
            this.buttonActive.UseVisualStyleBackColor = false;
            this.buttonActive.Click += new System.EventHandler(this.buttonActive_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1176, 70);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
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
            this.buttonSave.TabIndex = 10;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Сохранить";
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
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Редактировать";
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
            this.buttonBack.TabIndex = 8;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemReport,
            this.toolStripMenuItemCheck});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(174, 92);
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
            // toolStripMenuItemCheck
            // 
            this.toolStripMenuItemCheck.Name = "toolStripMenuItemCheck";
            this.toolStripMenuItemCheck.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemCheck.Text = "Чек";
            this.toolStripMenuItemCheck.Click += new System.EventHandler(this.toolStripMenuItemCheck_Click);
            // 
            // FormContracts
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContracts_FormClosing);
            this.Load += new System.EventHandler(this.FormContracts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormContracts_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.panelClientStatistics.ResumeLayout(false);
            this.panelClientStatistics.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxReturnByFact;
        private System.Windows.Forms.TextBox textBoxReturn;
        private System.Windows.Forms.TextBox textBoxReceiving;
        private System.Windows.Forms.TextBox textBoxCartridge;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Panel panelClientStatistics;
        private System.Windows.Forms.Button buttonNotReturned;
        private System.Windows.Forms.Button buttonInactive;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonActive;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCheck;
    }
}