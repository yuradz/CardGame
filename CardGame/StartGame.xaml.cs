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

namespace CardGame
{
    /// <summary>
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Window
    {
        private GameOptions _gameOptions;

        public StartGame()
        {
            InitializeComponent();
        }

        private void playerNamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_gameOptions.PlayAgainstComputer)
                okButton.IsEnabled = (playerNamesListBox.SelectedItems.Count == 1);
            else
                okButton.IsEnabled = (playerNamesListBox.SelectedItems.Count ==
                _gameOptions.NumberOfPlayers);
        }
    }
    }
}
