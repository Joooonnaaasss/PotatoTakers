using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;

namespace PotatoTakers
{
    public class GameControl
    {
        private Canvas canvas;
        private TextBlock lebenText;
        private TextBlock scoreText;
        private DispatcherTimer timer;
        private Random rand = new Random();

        public GameControl(Canvas gameCanvas, TextBlock txtLeben, TextBlock txtScore)
        {
            canvas = gameCanvas;
            lebenText = txtLeben;
            scoreText = txtScore;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void InitPlayer()
        {
            Rectangle player = new Rectangle
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Green
            };
            canvas.Children.Add(player);
            Canvas.SetLeft(player, 10);
            Canvas.SetTop(player, canvas.Height / 2);
        }

        public void AddTower(int x, int y)
        {
            Rectangle tower = new Rectangle
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Blue
            };
            canvas.Children.Add(tower);
            Canvas.SetLeft(tower, x);
            Canvas.SetTop(tower, y);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Zufällige Enemy-Spawns
            if (rand.NextDouble() < 0.02)
            {
                double y = rand.Next(30, Math.Max(31, (int)canvas.ActualHeight - 30));
                Ellipse enemy = new Ellipse
                {
                    Width = 30,
                    Height = 30,
                    Fill = Brushes.Red
                };
                canvas.Children.Add(enemy);
                Canvas.SetLeft(enemy, canvas.ActualWidth);
                Canvas.SetTop(enemy, y);
            }

            // Enemy-Bewegung nach links
            for (int i = canvas.Children.Count - 1; i >= 0; i--)
            {
                if (canvas.Children[i] is Ellipse enemy)
                {
                    double x = Canvas.GetLeft(enemy);
                    x -= 2;
                    Canvas.SetLeft(enemy, x);

                    if (x < 0)
                        canvas.Children.Remove(enemy);
                }
            }
        }
    }
}
