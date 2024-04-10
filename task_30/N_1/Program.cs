using System;
using MySql.Data.MySqlClient;

namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=bdtour_firm;password=root;SslMode=none";

            // объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            // Вывод всех туров
            string sql1 = "SELECT * FROM tours";

            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql1, conn);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) // reader.Read() возвращает true и переходит к следующему ряду.
                {
                    string row = $"{reader.GetString("tour_id")} | {reader.GetString("tour_name")} | {reader.GetString("price")} | {reader.GetString("description")}";
                    Console.WriteLine(row);
                }
            }

            // Удаление тура с id 1
            string sql2 = "DElETE FROM tours WHERE tour_id = 1";
            command = new MySqlCommand(sql2, conn);
            command.ExecuteNonQuery();

            // Вставка туриста в бд
            string sql3 = "INSERT INTO tourists (last_name, first_name, fathers_name) VALUES ('Иванов', 'Иван', 'Иванович')";
            command = new MySqlCommand(sql3, conn);
            command.ExecuteNonQuery();

            // Обновленеи туриста в бд
            string sql4 = "UPDATE tourists SET last_name = 'Иванов' WHERE tourist_id = 2";
            command = new MySqlCommand(sql4, conn);
            command.ExecuteNonQuery();

            conn.Close();

	    Console.ReadLine();
        }
    }
}
