using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=bdtour_firm;password=root;SslMode=none";

            PrintTours(connStr);
            DeleteTour(connStr);
            AddTourist(connStr);
            UpdateTourist(connStr);

            Console.ReadLine();
        }

        public static void PrintTours(string connStr)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            string query = "SELECT * FROM tours;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "tours");

            DataTable toursTable = dataset.Tables["tours"];
            foreach (DataRow row in toursTable.Rows)
            {
                int tourId = Convert.ToInt32(row["tour_id"]);
                string tourName = row["tour_name"].ToString();
                decimal price = Convert.ToDecimal(row["price"]);
                string description = row["description"].ToString();
                Console.WriteLine($"{tourId} | {tourName} | {price} | {description}");
            }

            connection.Close();
        }

        public static void DeleteTour(string connStr)
        {
            string tableName = "tours";
            string deleteCondition = "tour_id = 2";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                // Получение данных
                string selectQuery = $"SELECT * FROM {tableName}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                // Удаление данных
                DataRow[] rowsToDelete = dataSet.Tables[tableName].Select(deleteCondition);
                foreach (DataRow row in rowsToDelete)
                    row.Delete();

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataSet, tableName);

                Console.WriteLine("Данные успешно удалены.");
            }
        }

        public static void AddTourist(string connStr)
        {
            string tableName = "tourists";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                // Получение данных
                string selectQuery = $"SELECT * FROM {tableName}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                // Добавление данных
                DataRow newRow = dataSet.Tables[tableName].NewRow();
                newRow["last_name"] = "Иванов";
                newRow["first_name"] = "Иван";
                newRow["fathers_name"] = "Иванович";

                dataSet.Tables[tableName].Rows.Add(newRow);

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataSet, tableName);

                Console.WriteLine("Данные успешно добавлены.");
            }
        }

        public static void UpdateTourist(string connStr)
        {
            string tableName = "tourists";
            string updateCondition = "tourist_id = 4";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                // Получение данных
                string selectQuery = $"SELECT * FROM {tableName}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                // Изменение данных
                DataRow[] rowsToUpdate = dataSet.Tables[tableName].Select(updateCondition);
                foreach (DataRow row in rowsToUpdate)
                {
                    row["first_name"] = "Олег";
                }

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataSet, tableName);

                Console.WriteLine("Данные успешно изменены.");
            }
        }
    }
}
