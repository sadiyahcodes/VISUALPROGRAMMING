using System.Windows;
using System.Windows.Controls;

namespace WPFComboBoxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for the first ComboBox
        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if (combo != null && combo.SelectedItem is ComboBoxItem selectedItem)
            {
                textBox1.Text = selectedItem.Content.ToString();
            }
        }

        // Event handler for the second ComboBox
        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if (combo != null && combo.SelectedItem is ComboBoxItem selectedItem)
            {
                textBox2.Text = selectedItem.Content.ToString();
            }
        }
    }
}
