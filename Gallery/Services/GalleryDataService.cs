using System.Collections.Generic;

using Model;
using DataAccessLayer;

namespace Gallery.Services
{
    public class GalleryDataService : IDataService
    {
        private IArtGallery gallery; 

        public GalleryDataService()
        {
            gallery = new ArtGallery();
        }

        public GalleryDataService(ArtGallery g)
        {
            gallery = g;
        }
        public void DeletePainting(Painting painting)
        {
            gallery.DeletePainting(painting);
        }

        public List<Painting> GetAllPaintings()
        {
            return gallery.GetPaintings();
        }

        public Painting GetPaintingDetail(int PaintingId)
        {
            return gallery.GetPaintingById(PaintingId);
        }

        public void UpdatePainting(Painting painting)
        {
            gallery.UpdatePainting(painting);
        }
    }
}
