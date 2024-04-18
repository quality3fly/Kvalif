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
using System.Windows.Shapes;

namespace Квалификационный_Экзамен
{
    /// <summary>
    /// Логика взаимодействия для Zapravlenie.xaml
    /// </summary>
    public partial class Zapravlenie : Window
    {
        public double r ;
        public double r1;
        public Zapravlenie()
        {
            InitializeComponent();
        }

        private void Zapravka_Click(object sender, RoutedEventArgs e)
        {
            
            Toplivo toplivo = new Toplivo(Convert.ToDouble(r1), Convert.ToDouble(r));
            Storage storage = new Storage(Convert.ToDouble(r1), toplivo.Vivod());

            Zapravka zapravka = new Zapravka(Convert.ToDouble(Oby.Text),storage.Vivod() );
            Result.Content = "Объем топлива из хранилища"+" "+zapravka.Vivod().ToString();
        }
    }
}
