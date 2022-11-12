using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ColorGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Colors color;
        int Score = 0;
        enum Colors
        {
            red,
            green,
            blue,
            yellow
        }

        public MainWindow()
        {
            InitializeComponent();
            ChangeColor();
        }
        private void Button_Clicl_Minimize(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Button_Click_Max(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void ChangeColor()
        {
            TextBoxScore.Text = "Score: " + Score.ToString();
            var colorTmp = color;
            var random = new Random();
            var values = Enum.GetValues(typeof(Colors));
            while (colorTmp == color)
            {
                color = (Colors)values.GetValue(random.Next(values.Length));
            }
            while (colorTmp == color)
            {
                colorTmp = (Colors)values.GetValue(random.Next(values.Length));
            }
            SetText();
            SetColorText(colorTmp);
        }
        private void SetColorText(ColorGame.MainWindow.Colors colorTmp)
        {
            var bc = new BrushConverter();
            switch (colorTmp)
            {
                case Colors.blue:
                    {
                        TextBlockColor.Foreground = (Brush)bc.ConvertFrom("#1B5CD6");
                        break;
                    }
                case Colors.green:
                    {
                        TextBlockColor.Foreground = (Brush)bc.ConvertFrom("#1BD66A");
                        break;
                    }
                case Colors.red:
                    {
                        TextBlockColor.Foreground = (Brush)bc.ConvertFrom("#CB2440");
                        break;
                    }
                case Colors.yellow:
                    {
                        TextBlockColor.Foreground = (Brush)bc.ConvertFrom("#E5DD3F");
                        break;
                    }
            }
        }
        private void SetText()
        {
            switch (color)
            {
                case Colors.blue:
                    {
                        TextBlockColor.Text = "Blue";
                        break;
                    }
                case Colors.green:
                    {
                        TextBlockColor.Text = "Green";
                        break;
                    }
                case Colors.red:
                    {
                        TextBlockColor.Text = "Red";
                        break;
                    }
                case Colors.yellow:
                    {
                        TextBlockColor.Text = "Yellow";
                        break;
                    }
            }
        }
        private void ButtonGreen_Click(object sender, RoutedEventArgs e)
        {
            if (color == Colors.green)
            {
                Score++;
                ChangeColor();
            }
            else
            {
                Score = 0;
                ChangeColor();
            }
        }

        private void ButtonYellow_Click(object sender, RoutedEventArgs e)
        {
            if (color == Colors.yellow)
            {
                Score++;
                ChangeColor();
            }
            else
            {
                Score = 0;
                ChangeColor();
            }
        }

        private void ButtonBlue_Click(object sender, RoutedEventArgs e)
        {
            if (color == Colors.blue)
            {
                Score++;
                ChangeColor();
            }
            else
            {
                Score = 0;
                ChangeColor();
            }
        }

        private void ButtonRed_Click(object sender, RoutedEventArgs e)
        {
            if (color == Colors.red)
            {
                Score++;
                ChangeColor();
            }
            else
            {
                Score = 0;
                ChangeColor();
            }
        }
    }
}
