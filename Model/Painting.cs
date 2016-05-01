using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Model
{
    public class Painting : INotifyPropertyChanged
    {
        private int paintingId;
        private string paintingName;
        private int price;
        private string description;
        private Artist artistName;
        private bool inStock;
        private int amountInStock;
        private DateTime firstAquired;
        private BitmapImage image;

        public event PropertyChangedEventHandler PropertyChanged;

        public static BitmapImage SetImage(int PaintingId)
        {
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("/Gallery;component/Images/art" + PaintingId + ".jpg", UriKind.Relative);
            img.EndInit();
            return img;
        }

        public Painting(int Id)
        {
            PaintingId = Id;
            Image = SetImage(Id);
        }

        public int PaintingId
        {
            get { return paintingId; }
            set { paintingId = value; RaisePropertyChanged("PaintingId"); }
        }

        public string PaintingName
        {
            get { return paintingName; }
            set { paintingName = value; RaisePropertyChanged("PaintingName"); }
        }

        public int Price
        {
            get { return price; }
            set { price = value; RaisePropertyChanged("Price"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; RaisePropertyChanged("Description"); }
        }


        public Artist ArtistName
        {
            get { return artistName; }
            set { artistName = value;  RaisePropertyChanged("ArtistName"); }
        }

        public bool InStock
        {
            get { return inStock; }
            set { inStock = value; RaisePropertyChanged("InStock"); }
        }

        public int AmountInStock
        {
            get { return amountInStock; }
            set { amountInStock = value; RaisePropertyChanged("AmountInStock"); }
        }

        public DateTime FirstAquired
        {
            get { return firstAquired; }
            set { firstAquired = value; RaisePropertyChanged("FirstAquired"); }
        }

        public BitmapImage Image
        {
            get { return image; }
            set { image = value; RaisePropertyChanged("Image"); }
        }

        //public bool IsPaintingSelected
        //{
        //    get { return isPaintingSelected; }
        //    set { isPaintingSelected = value; RaisePropertyChanged("IsPaintingSelected"); }
        //}
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
