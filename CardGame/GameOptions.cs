using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ch13CardLib;

namespace CardGame
{
    [Serializable]
    public class GameOptions : INotifyPropertyChanged
    {
        private ObservableCollection<string> _playerNames =
            new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; }
        private bool _playAgainstComputer = true;
        private int _numberOfPlayers = 2;
        private ComputerSkillLevel _computerSkill = ComputerSkillLevel.Dumb;

        public GameOptions()
        {
            SelectedPlayers = new List<string>();
        }
        public ObservableCollection<string> PlayerNames
        {
            get => _playerNames;
            set
            {
                _playerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }
        public void AddPlayer(string newPlayer)
        {
            if (_playerNames.Contains(newPlayer))
                return;
            _playerNames.Add(newPlayer);
            OnPropertyChanged("PlayerNames");
        }
        public int NumberOfPlayers
        {
            get { return _numberOfPlayers; }
            set
            {
                _numberOfPlayers = value;
                OnPropertyChanged(nameof(NumberOfPlayers));
            }
        }
        public bool PlayAgainstComputer
        {
            get { return _playAgainstComputer; }
            set
            {
                _playAgainstComputer = value;
                OnPropertyChanged(nameof(PlayAgainstComputer));
            }
        }
        public ComputerSkillLevel ComputerSkill
        {
            get { return _computerSkill; }
            set
            {
                _computerSkill = value;
                OnPropertyChanged(nameof(ComputerSkill));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
