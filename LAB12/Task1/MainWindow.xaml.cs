using System.Windows;

namespace OrderInformationApp
{
    public partial class MainWindow : Window
    {
        private OrderViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new OrderViewModel();
            DataContext = _viewModel;
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle selection change if needed
        }

        private void ChangeAddress_Click(object sender, RoutedEventArgs e)
        {
            // For demonstration, we will create a new address directly.
            // In a real application, you would collect this from user input.
            var newAddress = new Address { Street = "789 Oak St", City = "Newtown", State = "TX", ZipCode = "54321" };

            var result = MessageBox.Show("Do you want to change the existing address or add a new one?", "Change Address", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                // Logic to update the existing address
                if (_viewModel.SelectedShippingAddress != null)
                {
                    _viewModel.SelectedShippingAddress.Street = newAddress.Street; // Update other fields as necessary
                }
            }
            else if (result == MessageBoxResult.No)
            {
                // Logic to add a new address
                _viewModel.Addresses.Add(newAddress);
                _viewModel.SelectedShippingAddress = newAddress; // Set the new address as selected
            }
        }
    }
}