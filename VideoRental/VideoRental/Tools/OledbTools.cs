using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace VideoRental.Tools
{
    public static class OledbTools
    {
        public static DataTable CreateTable(params string[] headerNames)
        {
            DataTable dataTable = new DataTable();

            foreach (string headerName in headerNames)
                dataTable.Columns.Add(headerName);

            return dataTable;
        }

        public static DataTable CreateTableForFilms()
        {
            DataTable dataTable = CreateTable("ID", "Title", "Genre", "Producer", "Premiere", "Description");
            dataTable.TableName = "Films";

            dataTable.Columns["ID"].Unique = true;
            dataTable.Columns["ID"].DataType = typeof(Int32);
            dataTable.Columns["Title"].DataType = typeof(string);
            dataTable.Columns["Producer"].DataType = typeof(int);
            dataTable.Columns["Genre"].DataType = typeof(string);
            dataTable.Columns["Premiere"].DataType = typeof(Int32);
            dataTable.Columns["Description"].DataType = typeof(string);

            return dataTable;
        }

        public static DataTable CreateTableForValueFilms()
        {
            DataTable dataTable = CreateTable("ID", "Title", "Genre", "Producer", "Premiere", "Description");
            dataTable.TableName = "Films";

            dataTable.Columns["ID"].Unique = true;
            dataTable.Columns["ID"].DataType = typeof(Int32);
            dataTable.Columns["Title"].DataType = typeof(string);
            dataTable.Columns["Producer"].DataType = typeof(string);
            dataTable.Columns["Genre"].DataType = typeof(string);
            dataTable.Columns["Premiere"].DataType = typeof(Int32);
            dataTable.Columns["Description"].DataType = typeof(string);

            return dataTable;
        }

        public static DataTable CreateTableForProducers()
        {
            DataTable dataTable = CreateTable("ID", "Producer", "Birthday", "Country", "Description");
            dataTable.TableName = "Producers";

            dataTable.Columns["ID"].Unique = true;
            dataTable.Columns["ID"].DataType = typeof(Int32);
            dataTable.Columns["Producer"].DataType = typeof(string);
            dataTable.Columns["Birthday"].DataType = typeof(DateTime);
            dataTable.Columns["Country"].DataType = typeof(string);
            dataTable.Columns["Description"].DataType = typeof(string);

            return dataTable;
        }

        public static DataTable CreateTableForCartridges()
        {
            DataTable dataTable = CreateTable("ID", "Title", "Cost per day", "Cost collateral", "Description");
            dataTable.TableName = "Producers";

            dataTable.Columns["ID"].Unique = true;
            dataTable.Columns["ID"].DataType = typeof(Int32);
            dataTable.Columns["Title"].DataType = typeof(string);
            dataTable.Columns["Cost per day"].DataType = typeof(decimal);
            dataTable.Columns["Cost collateral"].DataType = typeof(decimal);
            dataTable.Columns["Description"].DataType = typeof(string);

            return dataTable;
        }

        public static DataTable CreateTableForValueClient()
        {
            DataTable dataTable = CreateTable("ID", "Fullname", "Phone", "Email", "Address", "City");
            dataTable.TableName = "Clients";

            dataTable.Columns["ID"].Unique = true;
            dataTable.Columns["ID"].DataType = typeof(Int32);
            dataTable.Columns["Fullname"].DataType = typeof(string);
            dataTable.Columns["Phone"].DataType = typeof(string);
            dataTable.Columns["Email"].DataType = typeof(string);
            dataTable.Columns["Address"].DataType = typeof(string);
            dataTable.Columns["City"].DataType = typeof(string);

            return dataTable;
        }


        public static DataTable FillTable(this DataTable dataTable, OleDbCommand command)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            return dataTable;
        }


        public static DataTable GetSearchFilms(this DataTable dataTable, string str, string column)
        {
            DataTable dataTableTemp = CreateTableForValueFilms();

            IEnumerable<DataRow> rows = from row in dataTable.AsEnumerable() where row[column].ToString().ToLower().Contains(str.ToLower()) select row;

            foreach (DataRow row in rows)
                dataTableTemp.Rows.Add(row.ItemArray);

            return dataTableTemp;
        }

        public static DataTable GetSearchProducers(this DataTable dataTable, string str, string column)
        {
            DataTable result = CreateTableForProducers();

            IEnumerable<DataRow> rows;

            if (column != "Birthday")
                rows = from producer in dataTable.AsEnumerable().Where(row => row.Field<string>(column).ToString().ToLower().Contains(str.ToLower())) select producer;
            else
                rows = from producer in dataTable.AsEnumerable().Where(row => row.Field<DateTime>(column).Date.ToShortDateString().Contains(str)) select producer;

            foreach (DataRow row in rows)
                result.Rows.Add(row.ItemArray);

            return result;
        }

        public static DataTable GetSearchCartridges(this DataTable dataTable, string str)
        {
            DataTable dataTableTemp = CreateTableForCartridges();

            IEnumerable<DataRow> rows = from cartridge in dataTable.AsEnumerable().Where(row => row.Field<string>("Title").ToString().Contains(str)) select cartridge;

            foreach (DataRow row in rows)
                dataTableTemp.Rows.Add(row.ItemArray);

            return dataTableTemp;
        }

        public static DataTable GetSearchCartridges(this DataTable dataTable, decimal fromValue, decimal beforeValue = 999999)
        {
            DataTable dataTableTemp = CreateTableForCartridges();

            IEnumerable<DataRow> rows = from producer in dataTable.AsEnumerable() select producer;

            foreach (DataRow row in rows)
            {
                if ((Decimal.Parse(row.ItemArray[2].ToString()) >= fromValue) && (Decimal.Parse(row.ItemArray[2].ToString()) <= beforeValue))
                    dataTableTemp.Rows.Add(row.ItemArray);
            }

            return dataTableTemp;
        }

        public static DataTable GetSearchClients(this DataTable dataTable, string str, string column)
        {
            DataTable dataTableTemp = CreateTableForValueFilms();

            IEnumerable<DataRow> rows = from client in dataTable.AsEnumerable().Where(row => row.Field<string>(column).ToString().Contains(str)) select client;

            foreach (DataRow row in rows)
                dataTableTemp.Rows.Add(row.ItemArray);

            return dataTableTemp;
        }

        public static bool DeleteClient(OleDbCommand command, int clientId)
        {
            command.CommandText = String.Format("DELETE FROM Client WHERE Client.ID = {0}", clientId);
            int temp1 = command.ExecuteNonQuery();

            command.CommandText = String.Format("DELETE FROM ClientInfo WHERE ClientInfo.ID = {0}", clientId);

            int temp2 = command.ExecuteNonQuery();

            return (temp1 != 0) && (temp2 != 0) ? true : false;
        }
    }
}
