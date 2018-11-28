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

    public partial class EventDetails : Page
    {
        public EventDetails()
        {
            InitializeComponent();
        }

        // Custom constructor to pass expense report data
        public EventDetails(object data):this()
        {
            // Bind to expense report data.
            this.DataContext = data;
            
        }

        public void ButtonClick_Save(object sender, RoutedEventArgs e)
        {
            object data = this.DataContext;
            ServiceReference1.Event currentEvent = (ServiceReference1.Event)data;
            EventList.client.UpdateEvent(currentEvent);
            this.NavigationService.GoBack();
        }

        public void ButtonClick_Delete(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Er du sikker på at du vil slette dette event?", "Advarsel", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if(result == MessageBoxResult.OK)
            {
                object data = this.DataContext;
                ServiceReference1.Event currentEvent = (ServiceReference1.Event)data;
                EventList.client.DeleteEvent(currentEvent.Idk__BackingField);
                EventList.client.DeleteEvent(currentEvent.Idk__BackingField);
                this.NavigationService.GoBack();
            }
        }
        
    }
}
