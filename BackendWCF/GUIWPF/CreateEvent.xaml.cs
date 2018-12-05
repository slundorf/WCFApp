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

namespace GUIWPF
{
    /// <summary>
    /// Interaction logic for CreateEvent.xaml
    /// </summary>
    public partial class CreateEvent : Page
    {
        public CreateEvent()
        {
            InitializeComponent();
        }
        public void ButtonClick_Save(object sender, RoutedEventArgs e)
        {
            EventList.client.CreateEvent(navn_tb.Text, beskrivelse_tb.Text, dato_datepicker.SelectedDate ?? DateTime.Now, sted_tb.Text);
            this.NavigationService.GoBack();
        }

    }
}
