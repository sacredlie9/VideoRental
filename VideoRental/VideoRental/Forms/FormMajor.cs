using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using VideoRental.Tools;


namespace VideoRental.Forms
{
    public partial class FormMajor : Form
    {
        private bool isAdmin;

        public FormMajor()
        {
            this.isAdmin = false;

            InitializeComponent();

            Locked();
            textBoxPassword.InstallHintForPassword("Пароль");
        }

        private void FormMajor_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void FormMajor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelLocked.Visible)
                Login();
            else if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Home)
            {
                Locked();
                this.isAdmin = false;

                textBoxPassword.RemoveHintForPassword();
                textBoxPassword.Focus();
            }
        }

        private void buttonFilms_Click(object sender, EventArgs e)
        {
            //FormFilms formFilms = new FormFilms(this.isAdmin);
            //formFilms.Owner = this;

            //formFilms.ShowDialog();
            //this.Show();
            //formFilms.Dispose();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            //FormClients formClients = new FormClients();
            //formClients.Owner = this;

            //formClients.ShowDialog();
            //this.Show();
            //formClients.Dispose();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            //FormContracts formContracts = new FormContracts();
            //formContracts.Owner = this;

            //formContracts.ShowDialog();
            //this.Show();
            //formContracts.Dispose();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            Unlocked();
            Reject();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Locked();
            this.isAdmin = false;
            textBoxPassword.RemoveHintForPassword();
            textBoxPassword.Focus();
        }

        private void Accept()
        {
            this.isAdmin = true;
            this.buttonClients.Visible = true;
            this.buttonContracts.Visible = true;
            this.buttonHome.BackgroundImage = Image.FromFile("Images/exit.png");
        }

        private void Reject()
        {
            this.isAdmin = false;
            this.buttonClients.Visible = false;
            this.buttonContracts.Visible = false;
            this.buttonHome.BackgroundImage = Image.FromFile("Images/login.png");
        }

        private void Unlocked()
        {
            this.panelLocked.Visible = false;
            this.panelButtons.Visible = true;
        }

        private void Locked()
        {
            this.panelLocked.Visible = true;
            this.panelButtons.Visible = false;
            this.labelError.Visible = false;
        }

        private void Login()
        {
            string password;
            XmlSerializer formatter = new XmlSerializer(typeof(string));

            using (StreamReader sw = new StreamReader("Password.xml", false))
            {
                password = (string)formatter.Deserialize(sw);
            }

            if (password == textBoxPassword.Text)
            {
                Unlocked();
                Accept();
            }
            else
            {
                textBoxPassword.Focus();
                textBoxPassword.Text = "";
                this.labelError.Visible = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
                textBoxPassword.InstallHintForPassword("Пароль");
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
                textBoxPassword.RemoveHintForPassword();
            labelError.Visible = false;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Login();
            }
        }
    }
}
