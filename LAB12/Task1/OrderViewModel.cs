using System.Collections.ObjectModel;
using System.ComponentModel;

public class OrderViewModel : INotifyPropertyChanged
{
    private Address _selectedShippingAddress;

    public ObservableCollection<Address> Addresses { get; set; }

    public Address SelectedShippingAddress
    {
        get => _selectedShippingAddress;
        set
        {
            if (_selectedShippingAddress != value)
            {
                _selectedShippingAddress = value;
                OnPropertyChanged(nameof(SelectedShippingAddress));
            }
        }
    }

    public OrderViewModel()
    {
        Addresses = new ObservableCollection<Address>
        {
            new Address { Street = "123 Main St", City = "Anytown", State = "CA", ZipCode = "12345" },
            new Address { Street = "456 Elm St", City = "Othertown", State = "NY", ZipCode = "67890" }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}