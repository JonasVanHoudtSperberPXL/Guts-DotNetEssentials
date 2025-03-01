using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oef5_14;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ConvertButton_Click(object sender, RoutedEventArgs e)
    {
        int number = Convert.ToInt32(InputTextBox.Text);
        BinaryLabel.Content = ConvertToBinary(number);
    }

    public string ConvertToBinary(int amount)
    {
        int bit8 = amount / 128;
        amount -= bit8 * 128;

        int bit7 = amount % 128 / 64;
        amount -= bit7 * 64;

        int bit6 = amount % 64 / 32;
        amount -= bit6 * 32;

        int bit5 = amount % 32 / 16;
        amount -= bit5 * 16;

        int bit4 = amount % 16 / 8;
        amount -= bit4 * 8;

        int bit3 = amount % 8 / 4;
        amount -= bit3 * 4;

        int bit2 = amount % 4 / 2;
        amount -= bit2 * 2;

        int bit1 = amount % 2;

        return bit8 + "" + bit7 + "" + bit6 + "" + bit5 + "" + bit4 + "" + bit3 + "" + bit2 + "" + bit1;
    }
}