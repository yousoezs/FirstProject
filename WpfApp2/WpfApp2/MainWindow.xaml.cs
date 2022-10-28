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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person _person = new Person() { Name = "Toni", Age = 24};
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _person;
        }

        private void ShowOneWayInfo(object sender, RoutedEventArgs e)
        {
            var message = $"{_person.Name} is {_person.Age} years old";
            MessageBox.Show(message);
        }
    }
}
