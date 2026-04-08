using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace AvaloniaApplication2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void Celsius_TextChanged(object? sender, RoutedEventArgs e)
    {
        if (double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = " "; 
            Fahrenheit.Text = "0";
        }

        Debug.WriteLine($"Click Celsius={Celsius.Text}");
    }
}