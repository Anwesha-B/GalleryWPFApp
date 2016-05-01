using Model;
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

namespace Gallery.View
{
    /// <summary>
    /// Interaction logic for PaintingDetail.xaml
    /// </summary>
    public partial class PaintingDetail : Window
    {
        public Painting SelectedPainting { get; set; }
        public PaintingDetail()
        {
            InitializeComponent();
            this.Loaded += PaintingDetail_Loaded;
        }

        private void PaintingDetail_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedPainting;
        }

        private void DeletePaintingButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SavePaintingButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
