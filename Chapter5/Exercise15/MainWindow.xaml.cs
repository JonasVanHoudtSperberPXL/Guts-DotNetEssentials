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

namespace Oef5_15;

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
        ConvertSecondsToHoursMinutesSeconds(number, out int hours, out int minutes, out int seconds);

        OutputLabel.Content = hours + " hour(s), " + minutes + " minute(s) and " + seconds + " second(s)";
    }

    public void ConvertSecondsToHoursMinutesSeconds(int secondsIn, out int hours, out int minutes, out int secondsOut)
    {
        hours = secondsIn / 3600;
        secondsIn -= hours * 3600;

        minutes = secondsIn / 60;
        secondsIn -= minutes * 60;

        secondsOut = secondsIn;
    }
}