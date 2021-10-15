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
        }

        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            game.PlayerOneCard = game.SelectCard();

            game.PlayerTwoCard = game.SelectCard();

            CalcScore();
            UpdateScore();
            UpdateCardFields();

            if (game.CardDeck.Count < 2)
            {
                GameOverLabel.Visibility = Visibility.Visible;
                ToggleButtonVisibility();
            }
        }

        private void UpdateCardFields()
        {
            PlayerOneCardBox.Text = game.PlayerOneCard.ToString();
            PlayerTwoCardBox.Text = game.PlayerTwoCard.ToString();
        }

        private void ToggleButtonVisibility()
        {
            PlayButton.Visibility = (PlayButton.Visibility == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
            DealButton.Visibility = (DealButton.Visibility == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
            ToggleButtonVisibility();
        }

        private void UpdateScore()
        {
            PlayerOnePointsBox.Text = $"Score: {game.PlayerOneScore}";
            PlayerTwoPointsBox.Text = $"Score: {game.PlayerTwoScore}";
        }

        private void CalcScore()
        {
            if (game.PlayerOneCard.Value == game.PlayerTwoCard.Value)
            {
                game.PlayerOneScore++;
                game.PlayerTwoScore++;
            }
            else if (game.PlayerOneCard.Value > game.PlayerTwoCard.Value)
            {
                game.PlayerOneScore += 2;
            }
            else
            {
                game.PlayerTwoScore += 2;
            }
        }

        private void StartGame()
        {
            GameOverLabel.Visibility = Visibility.Hidden;
            game = new Game();
            game.FillDeck();
            PlayerOneCardBox.Text = "";
            PlayerTwoCardBox.Text = "";

            UpdateScore();
        }
    }
}
