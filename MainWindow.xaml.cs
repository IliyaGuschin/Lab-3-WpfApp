using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_3_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (TB != null)
            {
                TB.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (TB != null)
            {
                TB.FontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TB != null)
            {
                if (TB.FontWeight != FontWeights.Bold)
                {
                    TB.FontWeight = FontWeights.Bold;
                }
                else
                {
                    TB.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TB != null)
            {
                if (TB.FontStyle != FontStyles.Italic)
                {
                    TB.FontStyle = FontStyles.Italic;
                }
                else
                {
                    TB.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TB != null)
            {
                if (TB.TextDecorations != TextDecorations.Underline)
                {
                    TB.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    TB.TextDecorations = null;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (TB != null)
            {
                TB.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (TB != null)
            {
                TB.Foreground = Brushes.Red;
            }
        }
    }
}
