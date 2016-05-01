using Model;
using System.Collections.Generic;

namespace Gallery.Services
{
    public interface IDataService
    {
        void DeletePainting(Painting painting);
        List<Painting> GetAllPaintings();
        Painting GetPaintingDetail(int PaintingId);
        void UpdatePainting(Painting painting);
    }
}
