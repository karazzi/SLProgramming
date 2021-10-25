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
using Krig.Models;

namespace Krig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private Game game;
        public MainWindow()
        {
            InitializeComponent();
            game = new Game();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            InitGame();
            ToggleButtonVisibility(true);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            InitGame();
        }

        private void DealButton_Click(object sender, RoutedEventArgs e)
        {

            DealCards();

            List<Player> winners = GetWinners();
            UpdateScore(winners);

            if (game.CardDeck.Count < game.Players.Count)
            {
                ToggleButtonVisibility();
            }
        }
        private void InitGame()
        {
            game.FillDeck();

            UpdateCardTextBlock(true);
            UpdateScore(game.Players, true);
        }

        private void UpdateCardTextBlock(bool reset = false)
        {
            foreach (var player in game.Players)
            {
                string text = (reset) ? $"{player.Name}: " : $"{player.Name}: {player.Card}";

                Object obj = PlayersStackPanel.FindName($"PlayerTextBlockPlayer{player.Id}");
                if (obj is TextBlock)
                {
                    TextBlock tb = obj as TextBlock;
                    tb.Text = text;
                }
            }
        }

        private void DealCards()
        {
            foreach (var player in game.Players)
            {
                player.Card = game.SelectCard();
            }

            UpdateCardTextBlock();
        }

        private void ToggleButtonVisibility(bool newGame = false)
        {
            if (newGame)
            {
                ResetButton.Visibility = Visibility.Visible;
            }

            PlayButton.Visibility = (PlayButton.Visibility == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
            DealButton.Visibility = (DealButton.Visibility == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
        }

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player(game.Players.Count, AddPlayerName.Text);
            game.Players.Add(player);

            TextBlock tb = new TextBlock
            {
                Text = $"{player.Name}: "
            };
            PlayersStackPanel.RegisterName($"PlayerTextBlockPlayer{player.Id}", tb);
            PlayersStackPanel.Children.Add(tb);

            TextBlock tb1 = new TextBlock
            {
                Text = $"{AddPlayerName.Text}: "
            };
            ScoreStackPanel.RegisterName($"ScoreTextBlockPlayer{player.Id}", tb1);
            ScoreStackPanel.Children.Add(tb1);

        }


        private void UpdateScore(List<Player> winners, bool reset = false)
        {
            if (reset)
            {
                foreach (var player in game.Players)
                {
                    player.Score = 0;
                    UpdateScoreTextBlock(player);
                }
            }
            else{
                int newPoints = (winners.Count > 1) ? 1 : 2;
                foreach (var player in winners)
                {
                    player.Score += newPoints;
                    UpdateScoreTextBlock(player);
                }
            }
        }

        private void UpdateScoreTextBlock(Player player)
        {
            Object obj = ScoreStackPanel.FindName($"ScoreTextBlockPlayer{player.Id}");
            if (obj is TextBlock)
            {
                TextBlock tb = obj as TextBlock;
                tb.Text = $"{player.Name}: {player.Score}";
            }
        }

        private List<Player> GetWinners()
        {
            List<Player> winners = new List<Player>();
            int maxValue = game.Players.Max(p => p.Card.Value);
            winners.AddRange(game.Players.Where(p => p.Card.Value == maxValue));
            return winners;
        }

        
    }
}
