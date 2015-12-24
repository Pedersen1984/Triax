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
using Triax_Fejlrapportering;

namespace Triax_Fejlrapportering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Data> FailData;
        public MainWindow()
        {
            InitializeComponent();
            FailData = new List<Data>();
            xml xml = new xml();
            xml.ReadXml();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            Data data = new Data
            {
                Name = Navnbox.SelectedItem.ToString(),
                ComponentStockNumber = Navnbox.SelectedIndex,
                RepDate = DateTime.Now.Date,
                RepTime = TidSlider.Value,
                Fault = ÅrsagBox.SelectedItem.ToString(),
                Notes = Notebox.Text,
                PositionNumber = Notebox.Text,
                StockNumber = 2
            };
        }

        
        
    }
}
