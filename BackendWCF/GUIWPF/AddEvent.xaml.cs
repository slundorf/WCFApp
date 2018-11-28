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
    /// Interaction logic for AddEvent.xaml
    /// </summary>
    public partial class AddEvent : Page
    {
        public AddEvent()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public AddEvent(object data):this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
       
        
    }
}
