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

namespace gpa
{
    /// <summary>
    /// Interaction logic for options.xaml
    /// </summary>
    public partial class options : Page
    {
        public options()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            one o = new one();
            this.NavigationService.Navigate(o);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cgpa c = new cgpa();
            this.NavigationService.Navigate(c);
        }
    }
}
