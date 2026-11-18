using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace diak_nyilvantarto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = "server=localhost;user=root;password=;database=diak_gyak;";
            Console.Write("===== DIÁKNYILVÁNTARTÓ ===== \n\n1.Diákok listázása\n2.Új diák felvétele\n3.Diák adatainak módosítása\n4.Diák törlése\n5.Kilépés\n\nVálasztás: ");
            string input = Console.ReadLine();
            int choice = 0;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Input format error!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (choice > 5 || choice < 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid number!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            //using (MySqlConnection conn = new MySqlConnection(connString))
            //{
            //    try
            //    {
            //        conn.Open();
            //        Console.WriteLine("connection successful");
            //        string sql = "SELECT * FROM diakok;";
            //        MySqlCommand cmd = new MySqlCommand(sql, conn);
            //        MySqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine($"{reader["nev"],-20}{reader["eletkor"],-4}{reader["osztaly"]}");
            //        }
            //        Console.WriteLine();
            //        conn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"error: {ex.Message}");
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //}
        }
    }
}
