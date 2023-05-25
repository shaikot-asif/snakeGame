using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBDemo;
using Snake.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace Snake
{
    /// <summary>
    /// Interaction logic for GamePlay.xaml
    /// </summary>
    public partial class GamePlay : Window
    {

        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Users";
        string collectionName = "usersScore";



        private readonly Dictionary<GridValue, ImageSource> gridValToImage = new()
        {
            { GridValue.Empty,Images.Empty},
            { GridValue.Snake, Images.Body},
            { GridValue.Food,Images.Food }
        };

        private readonly Dictionary<Direction, int> dirToRotarion = new()
        {
            { Direction.Up,0 },
            { Direction.Right,90 },
            { Direction.Down, 180 },
            { Direction.Left, 270 }
        };

        private readonly int rows = 15, cols = 15;
        private readonly Image[,] gridImages;
        private GameState gameState;
        private bool gameRunning;

        public GamePlay()
        {
            InitializeComponent();
            gridImages = SetupGrid();
            gameState = new GameState(rows, cols);
        }

        private async Task RunGame()
        {
            Draw();
            await ShowCountDown();
            Overlay.Visibility = Visibility.Hidden;
            await GameLoop();
            await ShowGameOver();
            gameState = new GameState(rows, cols);

        }

        private async void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Overlay.Visibility == Visibility.Visible)
            {
                e.Handled = true;
            }

            if (!gameRunning)
            {
                gameRunning = true;
                await RunGame();
                gameRunning = false;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameState.GameOver)
            {
                return;
            }
            switch (e.Key)
            {
                case Key.Left:
                    gameState.changeDirection(dir: Direction.Left);
                    break;
                case Key.Right:
                    gameState.changeDirection(dir: Direction.Right);
                    break;
                case Key.Up:
                    gameState.changeDirection(dir: Direction.Up);
                    break;
                case Key.Down:
                    gameState.changeDirection(dir: Direction.Down);
                    break;
            }
        }

        private async Task GameLoop()
        {
            while (!gameState.GameOver)
            {
                if (gameState.Score > 5)
                {
                    await Task.Delay(250);
                    gameState.Move();
                    Draw();
                }
                else if (gameState.Score > 10)
                {
                    await Task.Delay(200);
                    gameState.Move();
                    Draw();
                }
                else if(gameState.Score> 15)
                {
                    await Task.Delay(150);
                    gameState.Move();
                    Draw();
                }
                else if (gameState.Score > 20)
                {
                    await Task.Delay(100);
                    gameState.Move();
                    Draw();
                }
                else
                {
                    await Task.Delay(300);
                    gameState.Move();
                    Draw();
                }
            }
        }
        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty,
                        RenderTransformOrigin = new Point(0.5, 0.5)
                    };
                    images[r, c] = image;
                    GameGrid.Children.Add(image);
                }
            }
            return images;
        }

        private void Draw()
        {
            DrawGrid();
            DrawSnakeHead();
            ScoreText.Text = $"SCORE: {gameState.Score}";
        }


       

        private void DrawGrid()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    GridValue gridVal = gameState.Grid[r, c];
                    gridImages[r, c].Source = gridValToImage[gridVal];
                    gridImages[r, c].RenderTransform = Transform.Identity;
                }
            }
        }

        private void DrawSnakeHead()
        {
            Position headPos = gameState.HeadPosition();
            Image image = gridImages[headPos.Row, headPos.Col];
            image.Source = Images.Head;

            int rotation = dirToRotarion[gameState.Dir];
            image.RenderTransform = new RotateTransform(rotation);
        }

        private async Task DrawDeadSnake()
        {
            List<Position> position = new List<Position>(gameState.SnakePositions());

            for (int i = 0; i < position.Count; i++)
            {
                Position pos = position[i];
                ImageSource source = (i == 0) ? Images.DeadHead : Images.DeadBody;
                gridImages[pos.Row, pos.Col].Source = source;
                await Task.Delay(80);
            }
        }

        private async Task ShowCountDown()
        {
            for (int i = 3; i >= 1; i--)
            {
                OverlayText.Text = i.ToString();
                await Task.Delay(500);
            }
        }

        /// <summary>
        /// BACK TO MAIN MENU BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }




        /// <summary>
        /// SAVE FINAL SCORE
        /// </summary>
        /// 

        public void saveScore()
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<UsersScore>(collectionName);


            bool GameOver = gameState.GameOver;
            var score = gameState.Score;

            string sun = MainWindow.UserScoreUserName;


            if (GameOver)
            {
                var UserScore = new UsersScore
                {
                    Id = ObjectId.GenerateNewId(),
                    Score = score,
                    UserName = sun
                };
                collection.InsertOne(UserScore);
                
            }
        }




        public async Task ShowGameOver()
        {
            saveScore();
            await DrawDeadSnake();
            await Task.Delay(1000);
            Overlay.Visibility = Visibility.Visible;
            MessageBox.Show("If you want to play this game simply press any key or If you want to go Main Menu Then you can press Main menu button");
            OverlayText.Text = "Press Any Key To Start The Game";

        }


    }
}
