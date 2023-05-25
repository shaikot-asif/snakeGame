using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBDemo;

namespace Snake
{
    /// <summary>
    /// Interaction logic for registration.xaml
    /// </summary>
    public partial class registration
    {
        
        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Users";
        string collectionName = "user";

        public registration()
        {
            InitializeComponent();

        }


        private async void formLogin_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<userModel>(collectionName);



            var filterUsername = Builders<userModel>.Filter.Eq(u => u.UserName, textUsername.Text);
            var result = await collection.FindAsync(filterUsername);


            
            if (result.Any())
            {
                MessageBox.Show("This Username already used, Please try another Username");
            }
            else if (textUsername.Text == "" && textPassword.Text == "" && textConPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (textPassword.Text == textConPassword.Text)
            {
                var user = new userModel
                {
                    Id = ObjectId.GenerateNewId(),
                    UserName = textUsername.Text,
                    Password = textConPassword.Text,
                };
                collection.InsertOne(user);


                textUsername.Text = "";
                textPassword.Text = "";
                textConPassword.Text = "";

                MessageBox.Show("your account has bees creatted successfully", "Registration successfull", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Password Does not match, Please re enter", "Registration faild", MessageBoxButton.OK, MessageBoxImage.Error);
                textPassword.Text = "";
                textConPassword.Text = "";
            }
        }

        private void btnBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();

            this.Hide();
        }

        
    }
}
