namespace VideoRental.Forms
{
    partial class FormMajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMajor));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFilms = new System.Windows.Forms.Button();
            this.panelFon = new System.Windows.Forms.Panel();
            this.panelLocked = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.buttonCloseLocked = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.panelFon.SuspendLayout();
            this.panelLocked.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.panelButtons.Controls.Add(this.buttonHome);
            this.panelButtons.Controls.Add(this.buttonContracts);
            this.panelButtons.Controls.Add(this.buttonClients);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonFilms);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(287, 600);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(202, 507);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(85, 85);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.TabStop = false;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.buttonContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContracts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContracts.FlatAppearance.BorderSize = 0;
            this.buttonContracts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonContracts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContracts.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContracts.ForeColor = System.Drawing.Color.White;
            this.buttonContracts.Location = new System.Drawing.Point(0, 338);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(287, 85);
            this.buttonContracts.TabIndex = 3;
            this.buttonContracts.Text = "Контракты";
            this.buttonContracts.UseVisualStyleBackColor = false;
            this.buttonContracts.Visible = false;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.Color.White;
            this.buttonClients.Location = new System.Drawing.Point(0, 208);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(287, 85);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Visible = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(0, 507);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(202, 85);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFilms
            // 
            this.buttonFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.buttonFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilms.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFilms.FlatAppearance.BorderSize = 0;
            this.buttonFilms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonFilms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilms.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilms.ForeColor = System.Drawing.Color.White;
            this.buttonFilms.Location = new System.Drawing.Point(0, 78);
            this.buttonFilms.Name = "buttonFilms";
            this.buttonFilms.Size = new System.Drawing.Size(287, 85);
            this.buttonFilms.TabIndex = 1;
            this.buttonFilms.Text = "Фильмы";
            this.buttonFilms.UseVisualStyleBackColor = false;
            this.buttonFilms.Click += new System.EventHandler(this.buttonFilms_Click);
            // 
            // panelFon
            // 
            this.panelFon.BackgroundImage = global::VideoRental.Properties.Resources.background1;
            this.panelFon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFon.Controls.Add(this.panelLocked);
            this.panelFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFon.Location = new System.Drawing.Point(287, 0);
            this.panelFon.Name = "panelFon";
            this.panelFon.Size = new System.Drawing.Size(513, 600);
            this.panelFon.TabIndex = 2;
            // 
            // panelLocked
            // 
            this.panelLocked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLocked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.panelLocked.Controls.Add(this.labelError);
            this.panelLocked.Controls.Add(this.buttonAccept);
            this.panelLocked.Controls.Add(this.textBoxPassword);
            this.panelLocked.Controls.Add(this.label1);
            this.panelLocked.Controls.Add(this.buttonVisitor);
            this.panelLocked.Controls.Add(this.buttonCloseLocked);
            this.panelLocked.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelLocked.Location = new System.Drawing.Point(106, 73);
            this.panelLocked.Name = "panelLocked";
            this.panelLocked.Size = new System.Drawing.Size(300, 449);
            this.panelLocked.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Brown;
            this.labelError.Location = new System.Drawing.Point(51, 165);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(202, 26);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Неверный пароль";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.ForeColor = System.Drawing.Color.White;
            this.buttonAccept.Location = new System.Drawing.Point(0, 194);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(300, 85);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.TabStop = false;
            this.buttonAccept.Text = "Вход";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(52, 134);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(199, 31);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите\r\nпароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.BackColor = System.Drawing.Color.Transparent;
            this.buttonVisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVisitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonVisitor.FlatAppearance.BorderSize = 0;
            this.buttonVisitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.buttonVisitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisitor.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisitor.ForeColor = System.Drawing.Color.White;
            this.buttonVisitor.Location = new System.Drawing.Point(0, 279);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(300, 85);
            this.buttonVisitor.TabIndex = 6;
            this.buttonVisitor.TabStop = false;
            this.buttonVisitor.Text = "Гость";
            this.buttonVisitor.UseVisualStyleBackColor = false;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // buttonCloseLocked
            // 
            this.buttonCloseLocked.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseLocked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseLocked.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCloseLocked.FlatAppearance.BorderSize = 0;
            this.buttonCloseLocked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.buttonCloseLocked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonCloseLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseLocked.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseLocked.ForeColor = System.Drawing.Color.White;
            this.buttonCloseLocked.Location = new System.Drawing.Point(0, 364);
            this.buttonCloseLocked.Name = "buttonCloseLocked";
            this.buttonCloseLocked.Size = new System.Drawing.Size(300, 85);
            this.buttonCloseLocked.TabIndex = 5;
            this.buttonCloseLocked.TabStop = false;
            this.buttonCloseLocked.Text = "Выход";
            this.buttonCloseLocked.UseVisualStyleBackColor = false;
            this.buttonCloseLocked.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelFon);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMajor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMajor_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMajor_KeyDown);
            this.panelButtons.ResumeLayout(false);
            this.panelFon.ResumeLayout(false);
            this.panelLocked.ResumeLayout(false);
            this.panelLocked.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFilms;
        private System.Windows.Forms.Panel panelFon;
        private System.Windows.Forms.Panel panelLocked;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.Button buttonCloseLocked;
    }
}