
using System.Collections.Generic;
using Model;

namespace DataAccessLayer
{
    public interface IArtGallery 
    {
        void DeletePainting(Painting painting);
        Painting GetPainting();
        Painting GetPaintingById(int id);
        List<Painting> GetPaintings();
        void UpdatePainting(Painting painting);

    }
}
