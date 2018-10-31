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
        public EventList()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            AddEvent AddEvent = new AddEvent(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(AddEvent);
        }
        private void getData()
        {
            Service1Client client = new Service1Client();
            client.GetAllEvents();
        }


    }
}
