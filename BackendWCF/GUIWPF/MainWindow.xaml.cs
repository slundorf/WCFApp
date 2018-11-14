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
using BackendWCF;


namespace GUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Event> items = new List<Event>();
            items.Add(new Event(1, "Event1", "Beskrivelse1", "12:23", "DTU"));
            items.Add(new Event(2, "EventToast", "Beskrivelse blblal", "12:22", "DTU Compute"));
            items.Add(new Event(3, "Event33333sdfsdfsdf", "Beskrivdfsdfselse1", "11:23", "Netto"));
            listBox.ItemsSource = items;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textOutput.Text = "Hello";
        }
    }
}
