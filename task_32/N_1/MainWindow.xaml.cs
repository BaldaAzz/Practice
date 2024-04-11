using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace N_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;database=bdtour_firm;password=root;SslMode=none";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                DataSet dataSet = new DataSet();


                string toursQuery = "SELECT * FROM tours";
                string touristsQuery = "SELECT * FROM tourists";


                DataTable toursTable = new DataTable("tours");
                DataTable touristsTable = new DataTable("tourists");


                MySqlDataAdapter toursAdapter = new MySqlDataAdapter(toursQuery, connection);
                toursAdapter.Fill(toursTable);

                MySqlDataAdapter touristsAdapter = new MySqlDataAdapter(touristsQuery, connection);
                touristsAdapter.Fill(touristsTable);

                dataSet.Tables.Add(toursTable);
                dataSet.Tables.Add(touristsTable);


                dataGridTours.ItemsSource = dataSet.Tables["tours"].DefaultView;
                dataGridTourists.ItemsSource = dataSet.Tables["tourists"].DefaultView;


                int tourCodeToDelete = 5;
                string deleteTourQuery = "DELETE FROM tours WHERE tour_id = @TourCode";
                MySqlCommand deleteTourCommand = new MySqlCommand(deleteTourQuery, connection);
                deleteTourCommand.Parameters.AddWithValue("@TourCode", tourCodeToDelete);
                int deletedRows = deleteTourCommand.ExecuteNonQuery();

                Console.WriteLine("Удалено {0} записей", deletedRows);


                int touristIdToUpdate = 1;
                string newName = "Антон";
                string updateTouristQuery = "UPDATE tourists SET first_name = @name WHERE tourist_id = @touristId";
                MySqlCommand updateTouristCommand = new MySqlCommand(updateTouristQuery, connection);
                updateTouristCommand.Parameters.AddWithValue("@name", newName);
                updateTouristCommand.Parameters.AddWithValue("@touristId", touristIdToUpdate);
                int updatedRows = updateTouristCommand.ExecuteNonQuery();

                Console.WriteLine("Изменено {0} записей", updatedRows);
            }
        }
    }
}
