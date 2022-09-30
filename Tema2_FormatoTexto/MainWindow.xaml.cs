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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Azul_RadioButton.IsChecked = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            salida_TextBlock.Text = Texto_TextBox.Text;
        }

        private void Negrita_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                salida_TextBlock.FontWeight = FontWeights.Bold;
                
        }

        private void Negrita_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontWeight = FontWeights.Normal;
        }

        private void Cursiva_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontStyle = FontStyles.Italic;
        }

        private void Cursiva_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontStyle = FontStyles.Normal;
        }

        private void Colorea(object sender, RoutedEventArgs e)
        {
            if (Azul_RadioButton.IsChecked == true)
                salida_TextBlock.Foreground = Brushes.Blue;
            else if (Rojo_RadioButton.IsChecked == true)
                salida_TextBlock.Foreground = Brushes.Red;
            else
                salida_TextBlock.Foreground = Brushes.Green;
        }

    }
}
