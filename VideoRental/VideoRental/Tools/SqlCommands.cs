﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace VideoRental
{
    public class SqlCommands
    {
        public static string CommandForFilms
        {
            get
            {
                return "SELECT " +
                    "Film.ID, " +
                    "Film.Title, " +
                    "Film.Producer, " +
                    "Film.Genre, " +
                    "Film.Premiere, " +
                    "Film.Description " +
                    "FROM Film";
            }
        }
    
        public static string CommandForValueFilms
        {
            get
            {
                return "SELECT " +
                    "Film.ID, " +
                    "Film.Title, " +
                    "Producer.Firstname + \" \" + Producer.Lastname AS Producer, " +
                    "Film.Genre, " +
                    "Film.Premiere, " +
                    "Film.Description " +
                    "FROM Film INNER JOIN Producer ON Film.Producer = Producer.ID";
            }
        }

        public static string CommandForPopularFilms
        {
            get
            {
                return "SELECT DISTINCT " +
                    "Film.ID, " +
                    "Film.Title, " +
                    "Producer.Firstname + \" \" + Producer.Lastname AS Name, " +
                    "Film.Genre, " +
                    "Film.Birthday, " +
                    "Film.Description " +
                    "FROM ((Producer INNER JOIN Film ON Producer.ID = Film.Producer) " +
                    "INNER JOIN Cartridge ON Film.ID = Cartridge.Film) " +
                    "INNER JOIN Contract ON Cartridge.ID = Contract.Cartridge";
            }
        }

        public static string CommandForNewFilms
        {
            get
            {
                return CommandForValueFilms + " WHERE Film.Birthday = @YearNow";
            }
        }

        public static string CommandForValueProducers
        {
            get
            {
                return "SELECT " +
                    "Producer.ID, " +
                    "Producer.Firstname + \" \" + Producer.Lastname AS Producer, " +
                    "Producer.Birthday, " +
                    "Producer.Country, " +
                    "Producer.Description " +
                    "FROM Producer";
            }
        }

        public static string CommandForValueCartridges
        {
            get
            {
                return "SELECT " +
                    "Cartridge.ID, " +
                    "Film.Title, " +
                    "Cartridge.[Cost per day], " +
                    "Cartridge.[Cost collateral], " +
                    "Cartridge.Description " +
                    "FROM Cartridge INNER JOIN Film ON Cartridge.Film = Film.ID";
            }
        }

        public static string CommandForValueClients
        {
            get
            {
                return "SELECT " +
                    "Client.ID, " +
                    "Client.Firstname + \" \" + Client.Lastname AS Fullname, " +
                    "ClientInfo.Phone, " +
                    "ClientInfo.Email, " +
                    "ClientInfo.Address, " +
                    "ClientInfo.City " +
                    "FROM Client INNER JOIN ClientInfo " +
                    "ON Client.ID = ClientInfo.ID";
            }
        }

        public static string CommandForActiveClients
        {
            get
            {
                return "SELECT " +
                    "Client.ID, " +
                    "Client.Firstname + \" \" + Client.Lastname AS Fullname, " +
                    "ClientInfo.Phone, " +
                    "ClientInfo.Email, " +
                    "ClientInfo.Address, " +
                    "ClientInfo.City " +
                    "FROM Client INNER JOIN ClientInfo " +
                    "ON Client.ID = ClientInfo.ID " +
                    "WHERE Client.ID IN (SELECT DISTINCT Contract.Client FROM Contract) " +
                    "GROUP BY Client.ID, Client.Firstname + \" \" + Client.Lastname, ClientInfo.Phone, ClientInfo.Email, ClientInfo.Address, ClientInfo.City";
            }
        }

        public static string CommandForInactiveClients
        {
            get
            {
                return "SELECT " +
                    "Client.ID, " +
                    "Client.Firstname + \" \" + Client.Lastname AS Fullname, " +
                    "ClientInfo.Phone, " +
                    "ClientInfo.Email, " +
                    "ClientInfo.Address, " +
                    "ClientInfo.City " +
                    "FROM Client INNER JOIN ClientInfo " +
                    "ON Client.ID = ClientInfo.ID " +
                    "WHERE Client.ID NOT IN (SELECT DISTINCT Contract.Client FROM Contract) " +
                    "GROUP BY Client.ID, Client.Firstname + \" \" + Client.Lastname, ClientInfo.Phone, ClientInfo.Email, ClientInfo.Address, ClientInfo.City";
            }
        }

        public static string CommandForDebtorsClients
        {
            get
            {
                return "SELECT " +
                    "Client.ID, " +
                    "Client.Firstname + \" \" + Client.Lastname AS Fullname, " +
                    "ClientInfo.Phone, " +
                    "ClientInfo.Email, " +
                    "ClientInfo.Address, " +
                    "ClientInfo.City " +
                    "FROM (Client INNER JOIN ClientInfo ON Client.ID = ClientInfo.ID) " +
                    "INNER JOIN Contract ON Client.ID = Contract.Client " +
                    "WHERE Client.ID IN (SELECT DISTINCT Contract.Client FROM Contract) " +
                    "AND Contract.[Date of returning actual] IS NULL " +
                    "GROUP BY Client.ID, Client.Firstname + \" \" + Client.Lastname, ClientInfo.Phone, ClientInfo.Email, ClientInfo.Address, ClientInfo.City";
            }
        }
    }
}
