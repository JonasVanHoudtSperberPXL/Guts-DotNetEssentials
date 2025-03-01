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

namespace Oef5_6;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DrawButton_Click(object sender, RoutedEventArgs e)
    {
        DrawStreet(150, 150, 100, 100, new SolidColorBrush(Colors.Blue), DrawingCanvas);
    }

    public void DrawStreet(int x, int y, int width, int height, SolidColorBrush color, Canvas canvas)
    {
        DrawHouse(x, y, width, height, color, canvas);
        DrawHouse(x + (width + 20), y, width, height, color, canvas);
        DrawHouse(x + 2 * (width + 20), y, width, height, color, canvas);
        DrawHouse(x + 3 * (width + 20), y, width, height, color, canvas);
    }

    public void DrawHouse(int x, int y, int width, int height, SolidColorBrush color, Canvas canvas)
    {
        DrawTriangle(x, y, width, height, color, canvas);
        DrawRectangle(x, y + 100, width, height, color, canvas);
    }

    public void DrawRectangle(int x, int y, int width, int height, SolidColorBrush color, Canvas canvas)
    {
        Rectangle rectangle = new Rectangle()
        {
            Width = width,
            Height = height,
            Margin = new Thickness(x, y, 0, 0),
            Stroke = color
        };
        canvas.Children.Add(rectangle);
    }

    public void DrawTriangle(int x, int y, int width, int height, SolidColorBrush color, Canvas canvas)
    {
        Line line1 = new Line()
        {
            X1 = x,
            Y1 = y,
            X2 = x,
            Y2 = y + 100,
            Stroke = color
        };

        Line line2 = new Line()
        {
            X1 = x,
            Y1 = y + 100,
            X2 = x + 100,
            Y2 = y + 100,
            Stroke = color
        };

        Line line3 = new Line()
        {
            X1 = x,
            Y1 = y,
            X2 = x + 100,
            Y2 = y + 100,
            Stroke = color
        };

        canvas.Children.Add(line1);
        canvas.Children.Add(line2);
        canvas.Children.Add(line3);
    }
}