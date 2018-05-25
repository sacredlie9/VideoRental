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
    public partial class FormFilms : Form
    {
        private bool isAdmin;

        public OleDbConnection Connection { get; set; }
        public DataTable Films { get; set; }
        public DataTable Producers { get; set; }
        public DataTable Cartridges { get; set; }

        public FormFilms() : this(false) { }

        public FormFilms(bool isAdmin)
        {
            InitializeComponent();

            this.isAdmin = isAdmin;
            this.Connection = new OleDbConnection(String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}VideoRental.accdb", AppDomain.CurrentDomain.BaseDirectory));
        }


        private void FormFilms_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            if (isAdmin)
            {
                buttonEdit.Visible = true;
                toolStripMenuItemEdit.Visible = true;
                toolStripMenuItemDelete.Visible = true;
            }
            else
            {
                buttonEdit.Visible = false;
                toolStripMenuItemEdit.Visible = false;
                toolStripMenuItemDelete.Visible = false;
            }

            InstallDataGridValues(new bool[] { true, true, true, });

            InstallHintFilms();
            InstallHintProducers();
            InstallHintCartridges();

            dataGridViewFilms.Columns[0].Visible = false;
            dataGridViewProducers.Columns[0].Visible = false;
            dataGridViewCartridges.Columns[0].Visible = false;
        }

        private void FormFilms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Connection.State == ConnectionState.Open)
                this.Connection.Close();
        }

        private void FormFilms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        private void InstallDataGridValues(bool[] updates)
        {
            if (updates[0] || updates[1] || updates[2])
            {
                OleDbCommand command = this.Connection.CreateCommand();

                try
                {
                    if (this.Connection.State == ConnectionState.Closed)
                        this.Connection.Open();

                    if (updates[0])
                    {
                        command.CommandText = SqlCommands.CommandForValueFilms;
                        this.Films = OledbTools.CreateTableForValueFilms().FillTable(command);
                    }
                    if (updates[1])
                    {
                        command.CommandText = SqlCommands.CommandForValueProducers;
                        this.Producers = OledbTools.CreateTableForProducers().FillTable(command);
                    }
                    if (updates[2])
                    {
                        command.CommandText = SqlCommands.CommandForValueCartridges;
                        this.Cartridges = OledbTools.CreateTableForCartridges().FillTable(command);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Название", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    this.Connection.Close();
                }
            }
        }

        private IDictionary<string, string> GetFilmSearcher()
        {
            Dictionary<string, string> searcher = new Dictionary<string, string>();

            if (!textBoxFilmTitle.IsEmpty("Название"))
                searcher.Add("Title", textBoxFilmTitle.Text);
            if (!textBoxFilmProducer.IsEmpty("Режиссер"))
                searcher.Add("Producer", textBoxFilmProducer.Text);
            if (!textBoxFilmGenre.IsEmpty("Жанр"))
                searcher.Add("Genre", textBoxFilmGenre.Text);
            if (!textBoxFilmYear.IsEmpty("Год премьеры"))
                searcher.Add("Premiere", textBoxFilmYear.Text);

            return searcher;
        }

        private IDictionary<string, string> GetProducerSearcher()
        {
            Dictionary<string, string> searcher = new Dictionary<string, string>();

            if (!textBoxProducerName.IsEmpty("Режиссер"))
                searcher.Add("Producer", textBoxProducerName.Text);
            if (!textBoxProducerBirthday.IsEmpty("Дата рождения"))
                searcher.Add("Birthday", textBoxProducerBirthday.Text);
            if (!textBoxProducerCountry.IsEmpty("Страна"))
                searcher.Add("Country", textBoxProducerCountry.Text);

            return searcher;
        }


        private void InstallFilms(IDictionary<string, string> searcher)
        {
            bool change = false;
            DataTable dataTableResult = this.Films;

            foreach (var item in searcher)
            {
                change = true;
                dataTableResult = dataTableResult.GetSearchFilms(item.Value, item.Key);
            }

            if (change)
                buttonFilmClear.Visible = true;
            else
                buttonFilmClear.Visible = false;

            dataGridViewFilms.DataSource = dataTableResult;
        }

        private void InstallProducers(IDictionary<string, string> searcher)
        {
            bool change = false;
            DataTable dataTableResult = this.Producers;

            foreach (var item in searcher)
            {
                change = true;
                dataTableResult = dataTableResult.GetSearchProducers(item.Value, item.Key);
            }

            if (change)
                buttonProducerClear.Visible = true;
            else
                buttonProducerClear.Visible = false;

            dataGridViewProducers.DataSource = dataTableResult;
        }

        private void InstallCartridges()
        {
            bool change = false;
            bool emptyPriceFrom = textBoxCartridgePriceFrom.IsEmpty("Стоимость от");
            bool emptyPriceBefore = textBoxCartridgePriceBefore.IsEmpty("Стоимость до");

            DataTable dataTableResult = this.Cartridges;

            if (!textBoxСartridgeFilm.IsEmpty("Фильм"))
            {
                change = true;
                dataTableResult = dataTableResult.GetSearchCartridges(textBoxСartridgeFilm.Text);
            }
            if (!emptyPriceFrom || !emptyPriceBefore)
            {
                change = true;

                if (!emptyPriceFrom && !emptyPriceBefore)
                    dataTableResult = dataTableResult.GetSearchCartridges(Decimal.Parse(textBoxCartridgePriceFrom.Text), Decimal.Parse(textBoxCartridgePriceBefore.Text));
                else if (!emptyPriceFrom)
                    dataTableResult = dataTableResult.GetSearchCartridges(Decimal.Parse(textBoxCartridgePriceFrom.Text));
                else
                    dataTableResult = dataTableResult.GetSearchCartridges(new decimal(0), Decimal.Parse(textBoxCartridgePriceBefore.Text));
            }
            if (change)
                buttonCartridgeClear.Visible = true;
            else
                buttonCartridgeClear.Visible = false;

            dataGridViewCartridges.DataSource = dataTableResult;
        }


        private void textBoxFilmFind_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Название" || textBox.Text == "Режиссер" || textBox.Text == "Жанр" || textBox.Text == "Год премьеры")
                textBox.RemoveHint();
        }

        private void textBoxFilmFind_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Название" || textBox.Text == "Режиссер" || textBox.Text == "Жанр" || textBox.Text == "Год премьеры")
                textBox.RemoveHint();
        }

        private void textBoxFilmFind_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                switch (textBox.Name)
                {
                    case "textBoxFilmTitle":
                        textBox.InstallHint("Название");
                        break;
                    case "textBoxFilmProducer":
                        textBox.InstallHint("Режиссер");
                        break;
                    case "textBoxFilmGenre":
                        textBox.InstallHint("Жанр");
                        break;
                    case "textBoxFilmYear":
                        textBox.InstallHint("Год премьеры");
                        break;
                }
            }
        }

        private void textBoxFilmFind_TextChanged(object sender, EventArgs e)
        {
            TextBox column = (TextBox)sender;
        
            InstallFilms(GetFilmSearcher());
        }

        private void textBoxFilmFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (textBox.Name)
            {
                case "textBoxFilmTitle":
                    textBox.ValidateTitle(e);
                    break;
                case "textBoxFilmProducer":
                    textBox.ValidateName(e);
                    break;
                case "textBoxFilmGenre":
                    textBox.ValidateName(e);
                    break;
                case "textBoxFilmYear":
                    textBox.ValidateYear(e);
                    break;
            }
        }


        private void textBoxProducerFind_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Режиссер" || textBox.Text == "Дата рождения" || textBox.Text == "Страна")
                textBox.RemoveHint();
        }

        private void textBoxProducerFind_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Режиссер" || textBox.Text == "Дата рождения" || textBox.Text == "Страна")
                textBox.RemoveHint();
        }

        private void textBoxProducerFind_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                switch (textBox.Name)
                {
                    case "textBoxProducerName":
                        textBox.InstallHint("Режиссер");
                        break;
                    case "textBoxProducerBirthday":
                        textBox.InstallHint("Дата рождения");
                        break;
                    case "textBoxProducerCountry":
                        textBox.InstallHint("Страна");
                        break;
                }
            }
        }

        private void textBoxProducerFind_TextChanged(object sender, EventArgs e)
        {
            InstallProducers(GetProducerSearcher());
        }

        private void textBoxProducerFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (textBox.Name)
            {
                case "textBoxProducerName":
                    textBox.ValidateName(e);
                    break;
                case "textBoxProducerBirthday":
                    textBox.ValidateNumber(e);
                    break;
                case "textBoxProducerCountry":
                    textBox.ValidateName(e);
                    break;
            }
        }


        private void textBoxCartridgeFind_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Фильм" || textBox.Text == "Стоимость от" || textBox.Text == "Стоимость до")
                textBox.RemoveHint();
        }

        private void textBoxСartridgeFind_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Фильм" || textBox.Text == "Стоимость от" || textBox.Text == "Стоимость до")
                textBox.RemoveHint();
        }

        private void textBoxСartridgeFind_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                switch (textBox.Name)
                {
                    case "textBoxСartridgeFilm":
                        textBox.InstallHint("Фильм");
                        break;
                    case "textBoxCartridgePriceFrom":
                        textBox.InstallHint("Стоимость от");
                        break;
                    case "textBoxCartridgePriceBefore":
                        textBox.InstallHint("Стоимость до");
                        break;
                }
            }
        }

        private void textBoxСartridgeFind_TextChanged(object sender, EventArgs e)
        {
            InstallCartridges();
        }

        private void textBoxСartridgeFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (textBox.Name)
            {
                case "textBoxСartridgeFilm":
                    textBox.ValidateTitle(e);
                    break;
                case "textBoxCartridgePriceFrom":
                    textBox.ValidateNumber(e);
                    break;
                case "textBoxCartridgePriceBefore":
                    textBox.ValidateNumber(e);
                    break;
            }
        }


        private void buttonFilmClear_Click(object sender, EventArgs e)
        {
            InstallHintFilms();
            dataGridViewFilms.DataSource = this.Films;
        }

        private void buttonProducerClear_Click(object sender, EventArgs e)
        {
            InstallHintProducers();
            dataGridViewProducers.DataSource = this.Producers;
        }

        private void buttonСartridgeClear_Click(object sender, EventArgs e)
        {
            InstallHintCartridges();
            dataGridViewCartridges.DataSource = this.Cartridges;
        }


        private void InstallHintFilms()
        {
            textBoxFilmTitle.InstallHint("Название");
            textBoxFilmProducer.InstallHint("Режиссер");
            textBoxFilmGenre.InstallHint("Жанр");
            textBoxFilmYear.InstallHint("Год премьеры");
        }

        private void InstallHintProducers()
        {
            textBoxProducerName.InstallHint("Режиссер");
            textBoxProducerBirthday.InstallHint("Дата рождения");
            textBoxProducerCountry.InstallHint("Страна");
        }

        private void InstallHintCartridges()
        {
            textBoxСartridgeFilm.InstallHint("Фильм");
            textBoxCartridgePriceFrom.InstallHint("Стоимость от");
            textBoxCartridgePriceBefore.InstallHint("Стоимость до");
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFilmPopular_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();
            InstallHintFilms();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetPopularFilm(command);
                //dataGridViewFilms.DataSource = result;
                //buttonFilmClear.Visible = true;
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

        private void buttonFilmNew_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();
            InstallHintFilms();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetNewFilm(command);
                //dataGridViewFilms.DataSource = result;
                //buttonFilmClear.Visible = true;
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

        private void buttonPriceMin_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();
            InstallHintCartridges();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetMinCartridge(command);
                //dataGridViewCartridges.DataSource = result;
                //buttonCartridgeClear.Visible = true;
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

        private void buttonPriceMax_Click(object sender, EventArgs e)
        {
            OleDbCommand command = this.Connection.CreateCommand();
            InstallHintCartridges();

            try
            {
                //this.Connection.Open();
                //DataTable result = OledbTools.GetMaxCartridge(command);
                //dataGridViewCartridges.DataSource = result;
                //buttonCartridgeClear.Visible = true;
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

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                Point pt = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                pt.X += e.Location.X;
                pt.Y += e.Location.Y;
                contextMenuStrip.Show(dataGridView, pt);
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            int tabSelect = tabControlFilms.SelectedIndex;
            int filmNumber = 0;
            int producerNumber = 0;
            int cartridgeNumber = 0;

            switch (tabSelect)
            {
                case 0:
                    int filmId = (int)dataGridViewFilms.SelectedRows[0].Cells[0].Value;

                    for (int i = 0; i < this.Films.Rows.Count; i++)
                    {
                        if (filmId.Equals((int)this.Films.Rows[i].ItemArray[0]))
                        {
                            filmNumber = i;
                            break;
                        }
                    }
                    break;
                case 1:
                    int producerId = (int)dataGridViewProducers.SelectedRows[0].Cells[0].Value;

                    for (int i = 0; i < this.Producers.Rows.Count; i++)
                    {
                        if (producerId.Equals((int)this.Producers.Rows[i].ItemArray[0]))
                        {
                            producerNumber = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    int cartridgeId = (int)dataGridViewCartridges.SelectedRows[0].Cells[0].Value;

                    for (int i = 0; i < this.Cartridges.Rows.Count; i++)
                    {
                        if (cartridgeId.Equals((int)this.Cartridges.Rows[i].ItemArray[0]))
                        {
                            cartridgeNumber = i;
                            break;
                        }
                    }
                    break;
            }

            //FormFilmsEdit formFilmsEdit = new FormFilmsEdit(this.Connection, tabSelect, filmNumber, producerNumber, cartridgeNumber);
            //formFilmsEdit.Owner = this;

            //formFilmsEdit.ShowDialog();
            //bool[] changes = formFilmsEdit.GetDataChanges();
            //formFilmsEdit.Dispose();
            //this.InstallDataGridValues(changes);
            //this.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int tabSelect = tabControlFilms.SelectedIndex;
            int filmId = 0;
            int producerId = 0;
            int cartridgeId = 0;
            string message = "";

            switch (tabSelect)
            {
                case 0:
                    filmId = (int)dataGridViewFilms.SelectedRows[0].Cells[0].Value;
                    message = String.Format("Вы действительно хотите удалить фильм {0}?", dataGridViewFilms.SelectedRows[0].Cells[1].Value.ToString());
                    break;
                case 1:
                    producerId = (int)dataGridViewProducers.SelectedRows[0].Cells[0].Value;
                    message = String.Format("Вы действительно хотите удалить режиссера {0} {1}?", dataGridViewProducers.SelectedRows[0].Cells[1].Value.ToString(), dataGridViewProducers.SelectedRows[0].Cells[2].Value.ToString());
                    break;
                case 2:
                    cartridgeId = (int)dataGridViewCartridges.SelectedRows[0].Cells[0].Value;
                    message = String.Format("Вы действительно хотите удалить кассету с фильмом {0} за {1}?", dataGridViewCartridges.SelectedRows[0].Cells[1].Value.ToString(), dataGridViewCartridges.SelectedRows[0].Cells[2].Value.ToString());
                    break;
            }

            var result = MessageBox.Show(message, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Connection.Open();
                    bool[] changes = new bool[] { false, false, false };

                    switch (tabSelect)
                    {
                        case 0:
                            //OledbTools.DeleteFilm(this.Connection.CreateCommand(), filmId);
                            changes[0] = true;
                            break;
                        case 1:
                            //OledbTools.DeleteProducer(this.Connection.CreateCommand(), producerId);
                            changes[1] = true;
                            break;
                        case 2:
                            //OledbTools.DeleteCartridge(this.Connection.CreateCommand(), cartridgeId);
                            changes[2] = true;
                            break;
                    }

                    this.InstallDataGridValues(changes);
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

        private void toolStripMenuItemReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "Файл PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                DataGridViewRow row;
                try
                {
                    //switch (tabControlFilms.SelectedIndex)
                    //{
                    //    case 0:
                    //        row = dataGridViewFilms.SelectedRows[0];
                    //        Stream.SaveFilm(path, row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), Int32.Parse(row.Cells[4].Value.ToString()), row.Cells[5].Value.ToString(), row.Cells[2].Value.ToString());
                    //        break;
                    //    case 1:
                    //        row = dataGridViewProducers.SelectedRows[0];
                    //        DataTable films = OledbTools.GetFilmsByProducer(OledbTools.GetFilms(this.Connection.CreateCommand()), (int)row.Cells[0].Value);
                    //        string[] temp = row.Cells[1].Value.ToString().Split(' ');
                    //        Stream.SaveProducer(path, temp[0], temp[1], (DateTime)row.Cells[2].Value, row.Cells[3].Value.ToString(), films, row.Cells[4].Value.ToString());
                    //        break;
                    //    case 2:
                    //        row = dataGridViewCartridges.SelectedRows[0];
                    //        DataRow film = OledbTools.GetFilm(this.Films, row.Cells[1].Value.ToString());
                    //        Stream.SaveCartridge(path, film.ItemArray[1].ToString(), film.ItemArray[3].ToString(), (int)film.ItemArray[4], (decimal)row.Cells[2].Value, (decimal)row.Cells[3].Value, row.Cells[4].Value.ToString());
                    //        break;
                    //}
                    MessageBox.Show("Файл сохранен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
