using MongoDB.Driver;
using MongoDBDemo;
using Snake.model;
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
using System.Windows.Shapes;

namespace Snake

{
    /// <summary>
    /// Interaction logic for ShowResults.xaml
    /// </summary>
    public partial class ShowResults : Window
    {

        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Users";
        string collectionName = "usersScore";
        public ShowResults()
        {
            InitializeComponent();
            ShowHighScore();
        }

        public void ShowHighScore() 
            {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<UsersScore>(collectionName);


            var maxScore = collection.Find(x => true).SortByDescending(x => x.Score).FirstOrDefault()?.Score;
            string? UserNme = collection.Find(x => true).SortByDescending(x => x.Score).FirstOrDefault()?.UserName;

            // ScoreText.Text = $"SCORE: {gameState.Score}";

            HighScoreText.Text = $"SCORE: {maxScore}";
            HighScoreTextName.Text = $"NAME: { UserNme}";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
