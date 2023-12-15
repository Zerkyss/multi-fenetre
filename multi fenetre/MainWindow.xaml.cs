using multi_fenetre.View;
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

namespace multi_fenetre
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            Grid_Container.Children.Clear();
            Home my_Home = new Home();
            Grid_Container.Children.Add(my_Home);
        }

        private void BTN_Gestion_Click(object sender, RoutedEventArgs e)
        {
            Grid_Container.Children.Clear();
            Gestion my_Gestion = new Gestion();
            Grid_Container.Children.Add(my_Gestion);
        }

        private void BTN_Config_Click(object sender, RoutedEventArgs e)
        {
            Grid_Container.Children.Clear();
            Configuration my_Config = new Configuration();
            Grid_Container.Children.Add(my_Config);
        }

        private void BTN_info_Click(object sender, RoutedEventArgs e)
        {
            Grid_Container.Children.Clear();
            Info my_Info = new Info();
            Grid_Container.Children.Add(my_Info);
        }
    }
}
