using Gallery.Extensions;
using Gallery.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for GalleryOverview.xaml
    /// </summary>
    public partial class GalleryOverview : Window
    {
        private Painting selectedPainting;
        private ObservableCollection<Painting> paintings;
        public GalleryOverview()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            GalleryDataService gDataService = new GalleryDataService();
            paintings = gDataService.GetAllPaintings().ToObservableCollection();
            PaintingsListView.ItemsSource = paintings;
        }

        private void Painting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPainting = e.AddedItems[0] as Painting;
            {
                if (selectedPainting != null)
                {
                    PaintingDetailView.DataContext = selectedPainting;

                    ArtistLabelHeader.Visibility = Visibility.Visible;
                    PriceLabelHeader.Visibility = Visibility.Visible;
                    StockAmountLabelHeader.Visibility = Visibility.Visible;
                    FirstTimeAddedLabelHeader.Visibility = Visibility.Visible;
                    Line.Visibility = Visibility.Visible;
                    ButtonBar.Visibility = Visibility.Visible;
                    DefaultTextLabel.Visibility = Visibility.Hidden;
                }
            }
        }

        private void EditPaintingButton_Click(object sender, RoutedEventArgs e)
        {
            PaintingDetail Detail = new PaintingDetail();
            Detail.SelectedPainting = selectedPainting;
            Detail.Show();
        }

        private void ModifyPaintingButton_Click(object sender, RoutedEventArgs e)
        {
            selectedPainting.PaintingName = "Expensive Painting";
            selectedPainting.Price = 10000000;
        }

        private void AddPaintingButton_Click(object sender, RoutedEventArgs e)
        {
            Painting painting = new Painting(3)
            {
                PaintingName = "Red Cardinal",
                Description = "Birs in Acrylic with bold, edgy and flat brush strokes capturing only the minimum details to portray the essense.  ",
                AmountInStock = 5,
                InStock = true,
                FirstAquired = new DateTime(2014, 3, 9),
                ArtistName = Artist.AngelaMouton,
                Price = 960,
            };
            paintings.Add(painting);
        }
    }
}
