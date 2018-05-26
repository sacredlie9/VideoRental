using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using VideoRental.Tools;

namespace VideoRental.Forms
{
    public partial class FormClients : Form
    {
        public OleDbConnection Connection { get; set; }
        public DataTable Clients { get; set; }

        public FormClients()
        {
            InitializeComponent();

            this.Connection = new OleDbConnection(String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}VideoRental.accdb", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            this.Owner?.Hide();

            InstallDataGridValues(true);

            InstallHintClients();
        }

        private void FormClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Connection.State == ConnectionState.Open)
                this.Connection.Close();
        }

        private void FormClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        private IDictionary<string, string> GetClientSearcher()
        {
            Dictionary<string, string> searcher = new Dictionary<string, string>();

            if (!textBoxClientName.IsEmpty("Имя"))
                searcher.Add("Fullname", textBoxClientName.Text);
            if (!textBoxClientPhone.IsEmpty("Телефон"))
                searcher.Add("Phone", textBoxClientPhone.Text);
            if (!textBoxClientMail.IsEmpty("Почта"))
                searcher.Add("Email", textBoxClientMail.Text);
            if (!textBoxClientAddress.IsEmpty("Адресс"))
                searcher.Add("Address", textBoxClientAddress.Text);
            if (!textBoxClientCity.IsEmpty("Город"))
                searcher.Add("City", textBoxClientCity.Text);

            return searcher;
        }

        private void InstallClients(IDictionary<string, string> searcher)
        {
            bool change = false;
            DataTable dataTableResult = this.Clients;

            foreach (var item in searcher)
            {
                change = true;
                dataTableResult = dataTableResult.GetSearchClients(item.Value, item.Key);
            }

            if (change)
                buttonClientClear.Visible = true;
            else
                buttonClientClear.Visible = false;

            dataGridViewClients.DataSource = dataTableResult;
        }

        private void InstallDataGridValues(bool update)
        {
            if (update)
            {
                try
                {
                    if (this.Connection.State == ConnectionState.Closed)
                        this.Connection.Open();

                    //OleDbCommand command = this.Connection.CreateCommand();
                    //command.CommandText = SqlCommands.CommandForValueFilms;

                    //this.Clients = OledbTools.CreateTableForValueClient().FillTable(command)
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    this.Connection.Close();
                }

                InstallClients(GetClientSearcher());
            }
        }

        private void InstallHintClients()
        {
            textBoxClientName.InstallHint("Имя");
            textBoxClientPhone.InstallHint("Телефон");
            textBoxClientMail.InstallHint("Почта");
            textBoxClientAddress.InstallHint("Адресс");
            textBoxClientCity.InstallHint("Город");
        }


        private void textBoxClientFind_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Имя" || textBox.Text == "Телефон" || textBox.Text == "Почта" || textBox.Text == "Адресс" || textBox.Text == "Город")
                textBox.RemoveHint();
        }

        private void textBoxClientFind_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Имя" || textBox.Text == "Телефон" || textBox.Text == "Почта" || textBox.Text == "Адресс" || textBox.Text == "Город")
                textBox.RemoveHint();
        }

        private void textBoxClientFind_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                switch (textBox.Name)
                {
                    case "textBoxClientName":
                        textBox.InstallHint("Имя");
                        break;
                    case "textBoxClientPhone":
                        textBox.InstallHint("Телефон");
                        break;
                    case "textBoxClientMail":
                        textBox.InstallHint("Почта");
                        break;
                    case "textBoxClientAddress":
                        textBox.InstallHint("Адресс");
                        break;
                    case "textBoxClientCity":
                        textBox.InstallHint("Город");
                        break;
                }
            }
        }

        private void textBoxClientFind_TextChanged(object sender, EventArgs e)
        {
            InstallClients(GetClientSearcher());
        }

        private void textBoxClientFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Name == "textBoxClientName")
                textBox.ValidateName(e);
            else if (textBox.Name == "textBoxClientMail")
                return;
            else
                textBox.ValidateTitle(e);
        }


        private void buttonClientClear_Click(object sender, EventArgs e)
        {
            InstallHintClients();
            dataGridViewClients.DataSource = this.Clients;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //FormClientsEdit formClientEdit = new FormClientsEdit(this.Connection, 0);
            //formClientEdit.Owner = this;

            //formClientEdit.ShowDialog();
            //bool change = formClientEdit.GetDataChanges();
            //formClientEdit.Dispose();
            //this.InstallDataGridValues(change);
            //this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string path = saveFileDialog.FileName;
                //try
                //{
                //    Stream.SaveTable((DataTable)dataGridViewClients.DataSource, path, "Список клиентов");

                //    MessageBox.Show("Файл сохренен");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }


        private void buttonClientActive_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetActiveClients(command);
                //dataGridViewClients.DataSource = result;
                //buttonClientClear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Connection.Close();
            }
        }

        private void buttonClientInactive_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetInactiveClients(command);
                //dataGridViewClients.DataSource = result;
                //buttonClientClear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Connection.Close();
            }
        }

        private void buttonClientDebtors_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetDebtorsClients(command);
                //dataGridViewClients.DataSource = result;
                //buttonClientClear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Connection.Close();
            }
        }


        private void dataGridViewClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewClients.ClearSelection();
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                Point pt = dataGridViewClients.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                pt.X += e.Location.X;
                pt.Y += e.Location.Y;
                contextMenuStrip.Show(dataGridViewClients, pt);
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            int clientNumber = 0;

            int filmId = (int)dataGridViewClients.SelectedRows[0].Cells[0].Value;

            for (int i = 0; i < this.Clients.Rows.Count; i++)
            {
                if (filmId.Equals((int)this.Clients.Rows[i].ItemArray[0]))
                {
                    clientNumber = i;
                    break;
                }
            }

            //FormClientsEdit formClientEdit = new FormClientsEdit(this.Connection, clientNumber);
            //formClientEdit.Owner = this;

            //formClientEdit.ShowDialog();
            //bool change = formClientEdit.GetDataChanges();
            //formClientEdit.Dispose();
            //this.InstallDataGridValues(change);
            //this.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int clientId = (int)dataGridViewClients.SelectedRows[0].Cells[0].Value;

            var result = MessageBox.Show(String.Format("Вы действительно хотите удалить клиента {0}?", dataGridViewClients.SelectedRows[0].Cells[1].Value.ToString()), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Connection.Open();
                OleDbTransaction transaction = this.Connection.BeginTransaction();

                try
                {
                    OleDbCommand command = this.Connection.CreateCommand();
                    command.Transaction = transaction;
                    //OledbTools.DeleteClient(command, clientId);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    transaction.Commit();
                    this.Connection.Close();

                    this.InstallDataGridValues(true);
                }
            }
        }

        private void toolStripMenuItemReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                //    DataGridViewRow row = dataGridViewClients.SelectedRows[0];
                //    string[] temp = row.Cells[1].Value.ToString().Split(' ');
                //    Stream.SaveClient(saveFileDialog.FileName, temp[0], temp[1], row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                //    MessageBox.Show("Файл сохранен");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
    }
}
