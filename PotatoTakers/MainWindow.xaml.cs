using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PotatoTakers
{
    public partial class MainWindow : Window
    {
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Enemy enemy = new Enemy(0, 100); // Startposition links
            GameManager.Enemies.Add(enemy);

            // Rotes Rechteck als Platzhalter
            Rectangle rect = new Rectangle
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Red
            };
            MyCanvas.Children.Add(rect);
            Canvas.SetLeft(rect, enemy.X);
            Canvas.SetTop(rect, enemy.Y);
        }

            private void MyCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (placingTower)
            {
                var pos = e.GetPosition(MyCanvas);

                Tower t = new Tower(pos.X, pos.Y);
                GameManager.Towers.Add(t);

                // Rechteck als Platzhalter
                Rectangle rect = new Rectangle
                {
                    Width = 40,
                    Height = 40,
                    Fill = Brushes.Green
                };
                MyCanvas.Children.Add(rect);
                Canvas.SetLeft(rect, t.X);
                Canvas.SetTop(rect, t.Y);

                placingTower = false;
            }
        }
    }
}
