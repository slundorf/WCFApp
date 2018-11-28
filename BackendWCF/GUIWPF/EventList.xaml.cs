using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUIWPF.ServiceReference1;

namespace GUIWPF
{
    /// <summary>
    /// Interaction logic for EventList.xaml
    /// </summary>
    public partial class EventList : Page
    {
        Service1Client client;
        static List<ServiceReference1.Event> events;
        

        public EventList()
        {
            InitializeComponent();
            try
            {
                client = new Service1Client();
                events = new List<ServiceReference1.Event>(); //lokal liste
                events = client.GetAllEvents();
                peopleListBox.ItemsSource = events;
            }
            catch (System.ServiceModel.EndpointNotFoundException e)
            {
                Console.WriteLine(e);
                MessageBoxResult result = MessageBox.Show("Kunne ikke oprette forbindelse til backend!", "Fejl", MessageBoxButton.OK, MessageBoxImage.Warning);
                System.Windows.Application.Current.Shutdown();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            AddEvent AddEvent = new AddEvent(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(AddEvent);
        }
    }
}
