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

namespace Interacciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            btn_MiBoton.Click += Btn_MiBoton_Click;
        }

        private void Btn_MiBoton_Click(object sender, RoutedEventArgs e)
        {
            lbl_Saludo.Text = "Adiós Mundo.";
            lbl_Saludo.FontSize = 29;
            lbl_Saludo.Foreground = Brushes.Red;
        }

        private void BtnMiSegundoBoton_Click(object sender, RoutedEventArgs e)
        {
            lbl_Saludo.Text = "Botón 2";
            lbl_Saludo.FontSize = 80;
            lbl_Saludo.Foreground = Brushes.BlueViolet;
        }

        private void BtnMiTercerBoton_Click(object sender, RoutedEventArgs e)
        {
            lbl_Saludo.Text = "3er Botón";
            lbl_Saludo.FontSize = 60;
            lbl_Saludo.Foreground = Brushes.Gold;
        }
    }
}
