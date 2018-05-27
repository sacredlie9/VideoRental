namespace VideoRental.Forms
{
    partial class FormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxClientCity = new System.Windows.Forms.TextBox();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.textBoxClientMail = new System.Windows.Forms.TextBox();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.panelClientStatistics = new System.Windows.Forms.Panel();
            this.buttonClientDebtors = new System.Windows.Forms.Button();
            this.buttonClientInactive = new System.Windows.Forms.Button();
            this.buttonClientClear = new System.Windows.Forms.Button();
            this.buttonClientActive = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
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
            this.panel1.Controls.Add(this.textBoxClientCity);
            this.panel1.Controls.Add(this.textBoxClientAddress);
            this.panel1.Controls.Add(this.textBoxClientMail);
            this.panel1.Controls.Add(this.textBoxClientPhone);
            this.panel1.Controls.Add(this.textBoxClientName);
            this.panel1.Controls.Add(this.dataGridViewClients);
            this.panel1.Controls.Add(this.panelClientStatistics);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 500);
            this.panel1.TabIndex = 1;
            // 
            // textBoxClientCity
            // 
            this.textBoxClientCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClientCity.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientCity.Location = new System.Drawing.Point(1070, 14);
            this.textBoxClientCity.MaxLength = 30;
            this.textBoxClientCity.Name = "textBoxClientCity";
            this.textBoxClientCity.Size = new System.Drawing.Size(260, 41);
            this.textBoxClientCity.TabIndex = 19;
            this.textBoxClientCity.Click += new System.EventHandler(this.textBoxClientFind_Click);
            this.textBoxClientCity.TextChanged += new System.EventHandler(this.textBoxClientFind_TextChanged);
            this.textBoxClientCity.Enter += new System.EventHandler(this.textBoxClientFind_Enter);
            this.textBoxClientCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFind_KeyPress);
            this.textBoxClientCity.Leave += new System.EventHandler(this.textBoxClientFind_Leave);
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClientAddress.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientAddress.Location = new System.Drawing.Point(804, 14);
            this.textBoxClientAddress.MaxLength = 30;
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(260, 41);
            this.textBoxClientAddress.TabIndex = 18;
            this.textBoxClientAddress.Click += new System.EventHandler(this.textBoxClientFind_Click);
            this.textBoxClientAddress.TextChanged += new System.EventHandler(this.textBoxClientFind_TextChanged);
            this.textBoxClientAddress.Enter += new System.EventHandler(this.textBoxClientFind_Enter);
            this.textBoxClientAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFind_KeyPress);
            this.textBoxClientAddress.Leave += new System.EventHandler(this.textBoxClientFind_Leave);
            // 
            // textBoxClientMail
            // 
            this.textBoxClientMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClientMail.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientMail.Location = new System.Drawing.Point(538, 14);
            this.textBoxClientMail.MaxLength = 30;
            this.textBoxClientMail.Name = "textBoxClientMail";
            this.textBoxClientMail.Size = new System.Drawing.Size(260, 41);
            this.textBoxClientMail.TabIndex = 17;
            this.textBoxClientMail.Click += new System.EventHandler(this.textBoxClientFind_Click);
            this.textBoxClientMail.TextChanged += new System.EventHandler(this.textBoxClientFind_TextChanged);
            this.textBoxClientMail.Enter += new System.EventHandler(this.textBoxClientFind_Enter);
            this.textBoxClientMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFind_KeyPress);
            this.textBoxClientMail.Leave += new System.EventHandler(this.textBoxClientFind_Leave);
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClientPhone.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientPhone.Location = new System.Drawing.Point(272, 14);
            this.textBoxClientPhone.MaxLength = 30;
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(260, 41);
            this.textBoxClientPhone.TabIndex = 16;
            this.textBoxClientPhone.Click += new System.EventHandler(this.textBoxClientFind_Click);
            this.textBoxClientPhone.TextChanged += new System.EventHandler(this.textBoxClientFind_TextChanged);
            this.textBoxClientPhone.Enter += new System.EventHandler(this.textBoxClientFind_Enter);
            this.textBoxClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFind_KeyPress);
            this.textBoxClientPhone.Leave += new System.EventHandler(this.textBoxClientFind_Leave);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxClientName.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientName.Location = new System.Drawing.Point(6, 14);
            this.textBoxClientName.MaxLength = 30;
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(260, 41);
            this.textBoxClientName.TabIndex = 15;
            this.textBoxClientName.Click += new System.EventHandler(this.textBoxClientFind_Click);
            this.textBoxClientName.TextChanged += new System.EventHandler(this.textBoxClientFind_TextChanged);
            this.textBoxClientName.Enter += new System.EventHandler(this.textBoxClientFind_Enter);
            this.textBoxClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFind_KeyPress);
            this.textBoxClientName.Leave += new System.EventHandler(this.textBoxClientFind_Leave);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 130);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClients.Size = new System.Drawing.Size(1176, 370);
            this.dataGridViewClients.TabIndex = 12;
            this.dataGridViewClients.TabStop = false;
            // 
            // panelClientStatistics
            // 
            this.panelClientStatistics.Controls.Add(this.buttonClientDebtors);
            this.panelClientStatistics.Controls.Add(this.buttonClientInactive);
            this.panelClientStatistics.Controls.Add(this.buttonClientClear);
            this.panelClientStatistics.Controls.Add(this.buttonClientActive);
            this.panelClientStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientStatistics.Location = new System.Drawing.Point(0, 70);
            this.panelClientStatistics.Name = "panelClientStatistics";
            this.panelClientStatistics.Size = new System.Drawing.Size(1176, 60);
            this.panelClientStatistics.TabIndex = 14;
            // 
            // buttonClientDebtors
            // 
            this.buttonClientDebtors.AutoSize = true;
            this.buttonClientDebtors.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientDebtors.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClientDebtors.FlatAppearance.BorderSize = 0;
            this.buttonClientDebtors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonClientDebtors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClientDebtors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientDebtors.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientDebtors.ForeColor = System.Drawing.Color.Black;
            this.buttonClientDebtors.Location = new System.Drawing.Point(400, 0);
            this.buttonClientDebtors.Name = "buttonClientDebtors";
            this.buttonClientDebtors.Size = new System.Drawing.Size(200, 60);
            this.buttonClientDebtors.TabIndex = 2;
            this.buttonClientDebtors.TabStop = false;
            this.buttonClientDebtors.Text = "Должники";
            this.buttonClientDebtors.UseMnemonic = false;
            this.buttonClientDebtors.UseVisualStyleBackColor = false;
            this.buttonClientDebtors.Click += new System.EventHandler(this.buttonClientDebtors_Click);
            // 
            // buttonClientInactive
            // 
            this.buttonClientInactive.AutoSize = true;
            this.buttonClientInactive.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientInactive.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClientInactive.FlatAppearance.BorderSize = 0;
            this.buttonClientInactive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonClientInactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClientInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientInactive.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientInactive.ForeColor = System.Drawing.Color.Black;
            this.buttonClientInactive.Location = new System.Drawing.Point(200, 0);
            this.buttonClientInactive.Name = "buttonClientInactive";
            this.buttonClientInactive.Size = new System.Drawing.Size(200, 60);
            this.buttonClientInactive.TabIndex = 3;
            this.buttonClientInactive.TabStop = false;
            this.buttonClientInactive.Text = "Неактивные";
            this.buttonClientInactive.UseMnemonic = false;
            this.buttonClientInactive.UseVisualStyleBackColor = false;
            this.buttonClientInactive.Click += new System.EventHandler(this.buttonClientInactive_Click);
            // 
            // buttonClientClear
            // 
            this.buttonClientClear.AutoSize = true;
            this.buttonClientClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClientClear.FlatAppearance.BorderSize = 0;
            this.buttonClientClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonClientClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClientClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientClear.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClientClear.Location = new System.Drawing.Point(976, 0);
            this.buttonClientClear.Name = "buttonClientClear";
            this.buttonClientClear.Size = new System.Drawing.Size(200, 60);
            this.buttonClientClear.TabIndex = 0;
            this.buttonClientClear.TabStop = false;
            this.buttonClientClear.Text = "Очистить";
            this.buttonClientClear.UseMnemonic = false;
            this.buttonClientClear.UseVisualStyleBackColor = false;
            this.buttonClientClear.Click += new System.EventHandler(this.buttonClientClear_Click);
            // 
            // buttonClientActive
            // 
            this.buttonClientActive.AutoSize = true;
            this.buttonClientActive.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClientActive.FlatAppearance.BorderSize = 0;
            this.buttonClientActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.buttonClientActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClientActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientActive.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientActive.ForeColor = System.Drawing.Color.Black;
            this.buttonClientActive.Location = new System.Drawing.Point(0, 0);
            this.buttonClientActive.Name = "buttonClientActive";
            this.buttonClientActive.Size = new System.Drawing.Size(200, 60);
            this.buttonClientActive.TabIndex = 1;
            this.buttonClientActive.TabStop = false;
            this.buttonClientActive.Text = "Активные";
            this.buttonClientActive.UseMnemonic = false;
            this.buttonClientActive.UseVisualStyleBackColor = false;
            this.buttonClientActive.Click += new System.EventHandler(this.buttonClientActive_Click);
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
            this.buttonSave.TabIndex = 6;
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
            this.buttonEdit.TabIndex = 5;
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
            this.buttonBack.TabIndex = 4;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormClients
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClients_FormClosing);
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClients_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.panelClientStatistics.ResumeLayout(false);
            this.panelClientStatistics.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxClientCity;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.TextBox textBoxClientMail;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Panel panelClientStatistics;
        private System.Windows.Forms.Button buttonClientDebtors;
        private System.Windows.Forms.Button buttonClientInactive;
        private System.Windows.Forms.Button buttonClientClear;
        private System.Windows.Forms.Button buttonClientActive;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReport;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonBack;
    }
}