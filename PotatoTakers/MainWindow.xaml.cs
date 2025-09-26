using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Controls;

namespace PotatoTakers
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer enemyTimer;   // Gegner spawnen
        private DispatcherTimer shootTimer;   // Türme schießen
        private bool placingTower = false;

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

            // Timer für Gegner
            enemyTimer = new DispatcherTimer();
            enemyTimer.Interval = TimeSpan.FromSeconds(3);
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Start();

            // Timer für Schüsse
            shootTimer = new DispatcherTimer();
            shootTimer.Interval = TimeSpan.FromSeconds(1);
            shootTimer.Tick += ShootTimer_Tick;
            shootTimer.Start();

            // Klick ins Spielfeld
            MyCanvas.MouseLeftButtonDown += MyCanvas_MouseLeftButtonDown;

            // Button Tower1
            BtnTower1.Click += (s, e) => placingTower = true;
        }

        private void EnemyTimer_Tick(object? sender, EventArgs e)
        {
            Enemy enemy = new Enemy(0, 100);
            GameManager.Enemies.Add(enemy);

            MyCanvas.Children.Add(enemy.Visual);
            Canvas.SetLeft(enemy.Visual, enemy.X);
            Canvas.SetTop(enemy.Visual, enemy.Y);
        }

        private void ShootTimer_Tick(object? sender, EventArgs e)
        {
            foreach (var tower in GameManager.Towers)
            {
                Schuss s = new Schuss(tower.X + 40, tower.Y + 15);
                tower.Schuesse.Add(s);

                MyCanvas.Children.Add(s.Visual);
                Canvas.SetLeft(s.Visual, s.X);
                Canvas.SetTop(s.Visual, s.Y);
            }
        }

        private void MyCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (placingTower)
            {
                var pos = e.GetPosition(MyCanvas);

                Tower t = new Tower(pos.X, pos.Y);
                GameManager.Towers.Add(t);

                MyCanvas.Children.Add(t.Visual);
                Canvas.SetLeft(t.Visual, t.X);
                Canvas.SetTop(t.Visual, t.Y);

                placingTower = false;
            }
        }
    }
}
