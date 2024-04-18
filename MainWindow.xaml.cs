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

namespace Квалификационный_Экзамен
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

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Toplivo toplivo = new Toplivo(Convert.ToDouble(Oby.Text), Convert.ToDouble(Plotnost.Text));

            Storage storage = new Storage(Convert.ToDouble(Oby.Text), Convert.ToDouble(Zapas.Text));
            Result.Content = "Масса топливо = " + " " + toplivo.Vivod().ToString()+"\nДоступное хранилище="+" "+storage.Vivod().ToString() ;
        }

        private void Zapravka_Click(object sender, RoutedEventArgs e)
        {
            Zapravlenie zapravlenie = new Zapravlenie();
            zapravlenie.r = Convert.ToDouble(Plotnost.Text);
            zapravlenie.r1 = Convert.ToDouble(Oby.Text);
            zapravlenie.Show();
        }
    }
}
