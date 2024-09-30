using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_0923_szerver.DatabaseManagement;
using WCF_0923_szerver.Models;

namespace WCF_0923_szerver.Controllers
{
    public class JogosultsagokController : BaseDatabaseManager, ISQL
    {
        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(Record record)
        {
            throw new NotImplementedException();
        }

        public List<Record> Select()
        {
            List<Record> list = new List<Record>();
            MySqlCommand cmd = new MySqlCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT * FROM Jogosultsagok"
            };

            try
            {
                MySqlConnection conn = BaseDatabaseManager.Connection;
                conn.Open();
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Jogosultsagok ujJog = new Jogosultsagok()
                    {
                        Id = reader.GetInt32("id"),
                        Szint=reader.GetInt32("Szint"),
                        Nev = reader.GetString("Nev"),
                        Leiras=reader.GetString("Leiras")
                        
                    };
                    list.Add(ujJog);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba! " + e.Message);
            }
            finally
            {
                BaseDatabaseManager.Connection.Close();
            }

            return list;
        }

        public string Update(Record record)
        {
            throw new NotImplementedException();
        }
    }
}