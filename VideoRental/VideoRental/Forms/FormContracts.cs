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
    public partial class FormContracts : Form
    {
        public OleDbConnection Connection { get; set; }

        public DataTable Contracts { get; set; }


        public FormContracts()
        {
            InitializeComponent();

            this.Connection = new OleDbConnection(String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}VideoRental.accdb", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            this.Owner?.Hide();

            this.Contracts = RequestTable();
            if (this.Contracts == null)
                this.Close();

            ChangeDataTable(GetSearcher());
            InstallHints();
        }

        private void FormContracts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Connection.State == ConnectionState.Open)
                this.Connection.Close();
        }

        private void FormContracts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        private IDictionary<string, string> GetSearcher()
        {
            Dictionary<string, string> searcher = new Dictionary<string, string>();

            if (!textBoxClient.IsEmpty("Клиент"))
                searcher.Add("Client", textBoxClient.Text);

            if (!textBoxCartridge.IsEmpty("Кассета"))
                searcher.Add("Cartridge", textBoxCartridge.Text);

            if (!textBoxReceiving.IsEmpty("Дата получения"))
                searcher.Add("Date of receiving", textBoxReceiving.Text);

            if (!textBoxReturn.IsEmpty("Дата возврата"))
                searcher.Add("Date of returning", textBoxReturn.Text);

            if (!textBoxReturnByFact.IsEmpty("Дата возврата по факту"))
                searcher.Add("Date of returning actual", textBoxReturnByFact.Text);

            return searcher;
        }

        private void ChangeDataTable(IDictionary<string, string> searcher)
        {
            DataTable result = this.Contracts;

            foreach (var item in searcher)
                //result = result.GetSearchContracts(item.Value, item.Key);

            dgvContracts.DataSource = result;
        }

        private DataTable RequestTable()
        {
            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();

                OleDbCommand command = this.Connection.CreateCommand();
                //command.CommandText = SqlCommands.CommandForValueContracts;

                return null;
                //return OledbTools.CreateTableForValueContract().FillTable(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                this.Connection.Close();
            }
        }

        private void InstallHints()
        {
            textBoxClient.InstallHint("Клиент");
            textBoxCartridge.InstallHint("Кассета");
            textBoxReceiving.InstallHint("Дата получения");
            textBoxReturn.InstallHint("Дата возврата");
            textBoxReturnByFact.InstallHint("Дата возврата по факту");
        }


        private void textBoxFind_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Клиент" || textBox.Text == "Кассета" || textBox.Text == "Дата получения" || textBox.Text == "Дата возврата" || textBox.Text == "Дата возврата по факту")
                textBox.RemoveHint();
        }

        private void textBoxFind_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Клиент" || textBox.Text == "Кассета" || textBox.Text == "Дата получения" || textBox.Text == "Дата возврата" || textBox.Text == "Дата возврата по факту")
                textBox.RemoveHint();
        }

        private void textBoxFind_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                switch (textBox.Name)
                {
                    case "textBoxClient":
                        textBox.InstallHint("Клиент");
                        break;
                    case "textBoxCartridge":
                        textBox.InstallHint("Кассета");
                        break;
                    case "textBoxReceiving":
                        textBox.InstallHint("Дата получения");
                        break;
                    case "textBoxReturn":
                        textBox.InstallHint("Дата возврата");
                        break;
                    case "textBoxReturnByFact":
                        textBox.InstallHint("Дата возврата по факту");
                        break;
                }
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            ChangeDataTable(GetSearcher());
        }

        private void textBoxFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Name == "textBoxClient")
                textBox.ValidateName(e);
            else if (textBox.Name == "textBoxCartridge")
                textBox.ValidateTitle(e);
            else
                textBox.ValidateNumber(e);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            InstallHints();
            dgvContracts.DataSource = this.Contracts;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //FormContractsEdit formContractsEdit = new FormContractsEdit(this.Connection, 0);
            //formContractsEdit.Owner = this;

            //formContractsEdit.ShowDialog();
            //bool change = formContractsEdit.GetDataChanges();
            //formContractsEdit.Dispose();
            //this.InstallDataGridValues(change);
            //this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "pdf";
            dialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //string path = saveFileDialog.FileName;
                //try
                //{
                //    Stream.SaveTable((DataTable)dataGridViewContracts.DataSource, path, "Ведомость");

                //    MessageBox.Show("Файл сохренен");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = this.Connection.CreateCommand();

                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();

                //DataTable result = OledbTools.GetActiveContracts(command);
                //dataGridViewContracts.DataSource = result;
                //buttonContractsClear.Visible = true;
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

        private void buttonInactive_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = this.Connection.CreateCommand();

                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();

                //DataTable result = OledbTools.GetInactiveContracts(command);
                //dataGridViewContracts.DataSource = result;
                //buttonContractsClear.Visible = true;
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

        private void buttonNotReturned_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();

            try
            {
                if (this.Connection.State == ConnectionState.Closed)
                    this.Connection.Open();

                //DataTable result = OledbTools.GetNotReturnsContracts(command);
                //dataGridViewContracts.DataSource = result;
                //buttonContractsClear.Visible = true;
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

                
        private void dgvContracts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvContracts.ClearSelection();
                dgvContracts.Rows[e.RowIndex].Selected = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                Point pt = dgvContracts.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                pt.X += e.Location.X;
                pt.Y += e.Location.Y;
                contextMenuStrip.Show(dgvContracts, pt);
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            int contractNumber = 0;
            int filmId = (int)dgvContracts.SelectedRows[0].Cells[0].Value;

            for (int i = 0; i < this.Contracts.Rows.Count; i++)
            {
                if (filmId.Equals((int)this.Contracts.Rows[i].ItemArray[0]))
                {
                    contractNumber = i;
                    break;
                }
            }

            //FormContractsEdit formContractsEdit = new FormContractsEdit(this.Connection, contractNumber);
            //formContractsEdit.Owner = this;

            //formContractsEdit.ShowDialog();
            //bool change = formContractsEdit.GetDataChanges();
            //formContractsEdit.Dispose();
            //this.InstallDataGridValues(change);
            //this.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int contractId = (int)dgvContracts.SelectedRows[0].Cells[0].Value;

            var result = MessageBox.Show(String.Format("Вы действительно хотите удалить договор с номером {0}?", contractId), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //try
                //{
                    //if (this.Connection.State == ConnectionState.Closed)
                    //    this.Connection.Open();

                //    OledbTools.DeleteContract(this.Connection.CreateCommand(), contractId);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //finally
                //{
                //    this.Connection.Close();

                //    this.InstallDataGridValues(true);
                //}
            }
        }

        private void toolStripMenuItemReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "pdf";
            dialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataGridViewRow row = dgvContracts.SelectedRows[0];
                    Stream.SaveContract(dialog.FileName, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), (DateTime)row.Cells[3].Value, (DateTime)row.Cells[4].Value, row.Cells[5].Value.ToString(), (bool)row.Cells[6].Value, (bool)row.Cells[7].Value);
                    MessageBox.Show("Файл сохранен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItemCheck_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "pdf";
            dialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (this.Connection.State == ConnectionState.Closed)
                        this.Connection.Open();

                    //DataGridViewRow row = dataGridViewContracts.SelectedRows[0];
                    //decimal price = OledbTools.GetPricePerCartridge(this.Connection.CreateCommand(), (int)row.Cells[0].Value);
                    //decimal collateral = OledbTools.GetPriceCollateral(this.Connection.CreateCommand(), (int)row.Cells[0].Value);
                    //Stream.SaveCheck(saveFileDialog.FileName, (int)row.Cells[0].Value, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), (DateTime)row.Cells[3].Value, (DateTime)row.Cells[4].Value, price, collateral);
                    //MessageBox.Show("Файл сохранен");
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
        }
    }

}
