using System.Windows;
using System.Windows.Input;

namespace PotatoTakers
{
    public partial class MainWindow : Window
    {
        private GameControl game;

        public MainWindow()
        {
            InitializeComponent();

            // GameControl initialisieren
            game = new GameControl(MyCanvas, TxtLeben, TxtScore);

            // Spieler platzieren
            game.InitPlayer();

            // Tower per Klick platzieren
            MyCanvas.MouseDown += (s, e) =>
            {
                var pos = e.GetPosition(MyCanvas);
                game.AddTower((int)pos.X, (int)pos.Y);
            };
        }
    }
}
