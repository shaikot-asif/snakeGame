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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playGame_Click(object sender, RoutedEventArgs e)
        {
            new GamePlay().Show();
            this.Hide();
        }

        private void playGame_Copy_Click(object sender, RoutedEventArgs e)
        {
            new ShowResults().Show();
            this.Hide();
        }

        private void playGame_Copy1_Click(object sender, RoutedEventArgs e)
        {
            new registration().Show();
            this.Hide();
        }
    }
}
