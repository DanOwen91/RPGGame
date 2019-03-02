using Engine.ViewModels;
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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();

            DataContext = _gameSession;
        }
        private void Button_Exp_OnClick(object sender, RoutedEventArgs args)
        {
            _gameSession.CurrentPlayer.ExperiencePoints += 10;
        }
        private void OnClick_MoveNorth(object sender, RoutedEventArgs args)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs args)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs args)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs args)
        {
            _gameSession.MoveSouth();
        }
        private void OnClick_TakeHome(object sender, RoutedEventArgs args)
        {
            _gameSession.TakeHome();
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                _gameSession.MoveNorth();
            }
            if (e.Key == Key.Down)
            {
                _gameSession.MoveSouth();
            }
            if (e.Key == Key.Right)
            {
                _gameSession.MoveEast();
            }
            if (e.Key == Key.Left)
            {
                _gameSession.MoveWest();
            }
            if (e.Key == Key.H)
            {
                _gameSession.TakeHome();
            }
        }
        private void OnClick_ContextMenuQuest(object sender, RoutedEventArgs e)
        {
            ContextMenu contextMenu = this.FindResource("QuestMenu") as ContextMenu;
            contextMenu.PlacementTarget = sender as Button;
            contextMenu.IsOpen = true;
        }
        private void OnClick_AcceptQuest(object sender, RoutedEventArgs e)
        {
            _gameSession.GivePlayerQuest();
        }
    }
}
