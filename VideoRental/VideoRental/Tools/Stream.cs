using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net.Mail;
using System.Net;

namespace VideoRental.Tools
{
    static class Stream
    {
        private static BaseFont baseFont = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

        private static Font font = new Font(baseFont, Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

        private static PdfPCell GetCell(string name, int size)
        {
            PdfPCell cell = new PdfPCell();

            cell.Colspan = size;
            cell.Border = 0;
            cell.HorizontalAlignment = 1;
            cell.Phrase = new Phrase(name, font);

            return cell;
        }

        public static void Save(this DataTable dataTable, string path, string name)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);

            table.AddCell(GetCell(name, dataTable.Columns.Count));

            PdfPCell emptyCell = GetCell(" ", dataTable.Columns.Count);
            table.AddCell(emptyCell);
            table.AddCell(emptyCell);

            PdfPCell cell = new PdfPCell();
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;

            foreach (DataColumn column in dataTable.Columns)
            {
                cell.Phrase = new Phrase(column.ColumnName, font);
                table.AddCell(cell);
            }

            cell.BackgroundColor = BaseColor.WHITE;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (object value in row.ItemArray)
                {
                    cell.Phrase = new Phrase(value.ToString(), font);
                    table.AddCell(cell);
                }
            }

            PdfPCell cellFooter = GetCell(String.Format("Количество записей: {0}", dataTable.Rows.Count), dataTable.Columns.Count);
            cellFooter.HorizontalAlignment = 2;

            table.AddCell(cellFooter);
            table.AddCell(emptyCell);

            cellFooter.Phrase = new Phrase("\"Прокат видеофильмов\"\t\t\t\tПодпись______________", font);
            cellFooter.HorizontalAlignment = 3;

            table.AddCell(cellFooter);
            table.AddCell(emptyCell);
            table.AddCell(emptyCell);

            cellFooter.Phrase = new Phrase(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), font);
            cellFooter.HorizontalAlignment = 2;

            table.AddCell(cellFooter);

            cellFooter.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);

            table.AddCell(cellFooter);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveFilm(string path, string title, string genre, int year, string info, string producer)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = GetCell(" ", 4);

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;

            table.AddCell(GetCell(String.Format("Информация о фильме {0}", title), 4));
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Название", font);
            cellValue.Phrase = new Phrase(title, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Жанр", font);
            cellValue.Phrase = new Phrase(genre, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Премьера", font);
            cellValue.Phrase = new Phrase(year.ToString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Режиссер", font);
            cellValue.Phrase = new Phrase(producer, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Информация", font);
            cellValue.Phrase = new Phrase(info, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellEmpty.HorizontalAlignment = 2;
            cellEmpty.Phrase = new Phrase(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), font);
            table.AddCell(cellEmpty);

            cellEmpty.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cellEmpty);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveProducer(string path, string name, string surname, DateTime birthday, string country, DataTable films, string info)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = GetCell(" ", 4);

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;

            table.AddCell(GetCell(String.Format("Информация о режиссере {0} {1}", name, surname), 4));
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Имя", font);
            cellValue.Phrase = new Phrase(name, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Фамилия", font);
            cellValue.Phrase = new Phrase(surname, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата рождения", font);
            cellValue.Phrase = new Phrase(birthday.ToLongDateString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Страна", font);
            cellValue.Phrase = new Phrase(country, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Информация", font);
            cellValue.Phrase = new Phrase(info, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            table.AddCell(GetCell("Фильмы", 4));
            table.AddCell(cellEmpty);

            PdfPCell cellTitle = new PdfPCell();
            PdfPCell cellGenre = new PdfPCell();
            PdfPCell cellInfo = new PdfPCell();

            cellTitle.Border = cellGenre.Border = cellInfo.Border = 1;
            cellTitle.BackgroundColor = cellGenre.BackgroundColor = cellInfo.BackgroundColor = BaseColor.LIGHT_GRAY;
            cellInfo.Colspan = 2;

            cellTitle.Phrase = new Phrase("Название", font);
            cellGenre.Phrase = new Phrase("Жанр", font);
            cellInfo.Phrase = new Phrase("Информация", font);
            table.AddCell(cellTitle);
            table.AddCell(cellGenre);
            table.AddCell(cellInfo);

            foreach (DataRow row in films.Rows)
            {
                table.AddCell(GetCell(row["Title"].ToString(), 1));
                table.AddCell(GetCell(row["Genre"].ToString(), 1));
                table.AddCell(GetCell(row["Description"].ToString(), 2));
            }

            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            PdfPCell cell = GetCell(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), 4);
            cell.HorizontalAlignment = 2;
            table.AddCell(cell);

            cell.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cell);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveCartridge(string path, string title, string genre, int year, decimal priceDay, decimal priceCollateral, string info)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = GetCell(" ", 4);

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;

            table.AddCell(GetCell(String.Format("Информация о кассете с фильмом {0} стоимость {1} грн", title, priceDay), 4));
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Фильм", font);
            cellValue.Phrase = new Phrase(title, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Жанр", font);
            cellValue.Phrase = new Phrase(genre, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Год премьеры", font);
            cellValue.Phrase = new Phrase(year.ToString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Стоимость (грн/дн)", font);
            cellValue.Phrase = new Phrase(priceDay.ToString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Стоимость залога", font);
            cellValue.Phrase = new Phrase(priceCollateral.ToString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Информация", font);
            cellValue.Phrase = new Phrase(info, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            PdfPCell cell = GetCell(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), 4);
            cell.HorizontalAlignment = 2;

            table.AddCell(cell);

            cell.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cell);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveClient(string path, string name, string surname, string phone, string email, string address, string city)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = GetCell(" ", 4);

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;

            table.AddCell(GetCell(String.Format("Информация о клиенте {0} {1}", name, surname), 4));
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Имя", font);
            cellValue.Phrase = new Phrase(name, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Фамилия", font);
            cellValue.Phrase = new Phrase(surname, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Телефон", font);
            cellValue.Phrase = new Phrase(phone, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Почта", font);
            cellValue.Phrase = new Phrase(email, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Адресс", font);
            cellValue.Phrase = new Phrase(address, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Город", font);
            cellValue.Phrase = new Phrase(city, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellEmpty.HorizontalAlignment = 2;
            cellEmpty.Phrase = new Phrase(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), font);
            table.AddCell(GetCell(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), 2));

            cellEmpty.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cellEmpty);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveContract(string path, string client, string cartridge, DateTime receiving, DateTime dateReturn, string returnByFact, bool pledge, bool payment)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = GetCell(" ", 4);

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;

            table.AddCell(GetCell(String.Format("Информация о контракте на кассету {0}", cartridge), 4));
            table.AddCell(cellEmpty);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Клиент", font);
            cellValue.Phrase = new Phrase(client, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Кассета", font);
            cellValue.Phrase = new Phrase(cartridge, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата получения", font);
            cellValue.Phrase = new Phrase(receiving.ToLongDateString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата возврата", font);
            cellValue.Phrase = new Phrase(dateReturn.ToLongDateString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата возврата по факту", font);
            cellValue.Phrase = new Phrase(returnByFact != "" ? returnByFact : "Кассета еще не возвращена", font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Оплата залога", font);
            cellValue.Phrase = new Phrase(pledge ? "Залог оплачен" : "Залог не оплачен", font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Оплата", font);
            cellValue.Phrase = new Phrase(payment ? "Кассета оплачена" : "Кассета не оплачена", font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellEmpty.HorizontalAlignment = 2;
            cellEmpty.Phrase = new Phrase(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), font);
            table.AddCell(cellEmpty);

            cellEmpty.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cellEmpty);

            doc.Add(table);
            doc.Close();
        }

        public static void SaveCheck(string path, int contractId, string client, string cartridge, DateTime receiving, DateTime dateReturn, decimal pricePerDay, decimal collateral)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(4);
            PdfPCell cellHeader = new PdfPCell();
            PdfPCell cellValue = new PdfPCell();
            PdfPCell cellEmpty = new PdfPCell();

            cellHeader.Border = cellValue.Border = cellEmpty.Border = 0;
            cellValue.Colspan = 3;
            cellEmpty.HorizontalAlignment = 1;
            cellEmpty.Colspan = 4;
            cellEmpty.Phrase = new Phrase(String.Format("Чек №{0}", contractId), font);

            table.AddCell(cellEmpty);

            cellEmpty.Phrase = new Phrase(new string('=', 20));
            table.AddCell(cellEmpty);
            cellEmpty.Phrase = new Phrase(" ");
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Клиент", font);
            cellValue.Phrase = new Phrase(client, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Кассета", font);
            cellValue.Phrase = new Phrase(cartridge, font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата получения", font);
            cellValue.Phrase = new Phrase(receiving.ToLongDateString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Дата возврата", font);
            cellValue.Phrase = new Phrase(dateReturn.ToLongDateString(), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Цена за день", font);
            cellValue.Phrase = new Phrase(String.Format("{0} грн", pricePerDay), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Цена залога", font);
            cellValue.Phrase = new Phrase(String.Format("{0} грн", collateral), font);
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);

            cellHeader.Phrase = new Phrase("Цена к оплате", font);
            cellValue.Phrase = new Phrase(String.Format("{0} грн", ((dateReturn - receiving).Days * pricePerDay) + collateral), font);
            cellHeader.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cellHeader);
            table.AddCell(cellValue);
            table.AddCell(cellEmpty);


            cellEmpty.HorizontalAlignment = 2;
            cellEmpty.Phrase = new Phrase(String.Format("Дата создания: {0}", DateTime.Now.ToLongDateString()), font);
            table.AddCell(cellEmpty);

            cellEmpty.Phrase = new Phrase(String.Format("Время создания: {0}", DateTime.Now.ToLongTimeString()), font);
            table.AddCell(cellEmpty);

            doc.Add(table);
            doc.Close();
        }
    }
}
