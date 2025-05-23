using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TravelPlanner;

public partial class MainWindow : Window
{
    private ObservableCollection<string> miasta = new ObservableCollection<string>();

    public MainWindow()
    {
        InitializeComponent();
        miastoLista.ItemsSource = miasta;
        miastoButton.Click += dodajMiasto;
    }

    public void dodajMiasto(object? sender, RoutedEventArgs e)
    {
        string miasto = miastoDodaj.Text.Trim();

        if (!string.IsNullOrEmpty(miasto))
        {
            miasta.Add(miasto);
            miastoDodaj.Text = "";
        }
    }
}