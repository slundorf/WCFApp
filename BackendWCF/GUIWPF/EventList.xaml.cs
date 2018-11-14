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
using GUIWPF.ServiceReference1;

namespace GUIWPF
{
    /// <summary>
    /// Interaction logic for EventList.xaml
    /// </summary>
    public partial class EventList : Page
    {
        Service1Client client;
        static List<Event> events;

        public EventList()
        {
            InitializeComponent();
            client = new Service1Client();
            events = new List<Event>();
            peopleListBox.ItemsSource = events;
            getData();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            AddEvent AddEvent = new AddEvent(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(AddEvent);
        }

        private void getData()
        {
            //TEST DATA
            events.Add(new Event(1, "Event1", "Beskrivelse1", "12:23", "DTU"));
            events.Add(new Event(2, "Event2", "Beskrivelse1", "12:23", "DTU"));


        }


    }
}
