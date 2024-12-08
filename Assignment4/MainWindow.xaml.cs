using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        // ObservableCollection for dynamic data binding
        public ObservableCollection<string> Players { get; set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            PlayerListBox.ItemsSource = Players; // Bind the ListBox to the ObservableCollection
        }

        // Handle Add Player button click
        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (Players.Contains(playerName))
            {
                MessageBox.Show("Player already exists in the roster.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Players.Add(playerName); // Add player to the collection
                PlayerNameTextBox.Clear(); // Clear the TextBox
            }
        }

        // Handle Remove Player button click
        private void RemovePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerListBox.SelectedItem is string selectedPlayer)
            {
                Players.Remove(selectedPlayer); // Remove selected player
            }
            else
            {
                MessageBox.Show("Please select a player to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Handle placeholder visibility
        private void PlayerNameTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            PlaceholderTextBlock.Visibility = string.IsNullOrEmpty(PlayerNameTextBox.Text)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
    }
}
