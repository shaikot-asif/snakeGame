using MongoDB.Driver;
using MongoDBDemo;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Input;

namespace Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        public static string UserScoreUserName { get; set; }

        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Users";
        string collectionName = "user";
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void formLogin_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<userModel>(collectionName);

            var filterUsername = Builders<userModel>.Filter.Eq(u => u.UserName, textUsername.Text);
            //var resultUseraname = collection.Find(filterUsername).ToList();
            var filterPassword = Builders<userModel>.Filter.Eq(p => p.Password, textPassword.Text);
           // var resultPassword = collection.Find(filterPassword).ToList();

            var result = await collection.FindAsync(filterUsername);
            var result2 = await collection.FindAsync(filterPassword);
            if (result.Any() && result2.Any())
            {
                UserScoreUserName = textUsername.Text;
                // Login successful, do something here
                MessageBox.Show("Login successful");
                new MainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or email are wrong");
            }


        }

        private void btnBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            new registration().Show();
            this.Hide();
        }



    }
}
