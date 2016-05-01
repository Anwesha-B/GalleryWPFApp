﻿
using System;
using System.Collections.Generic;
using Model;
using System.Linq;


namespace DataAccessLayer
{
    public class ArtGallery : IArtGallery
    {
        private static List<Painting> paintings;

        public ArtGallery() { }


        public void DeletePainting(Painting painting)
        {
            paintings.Remove(painting);
        }

        public Painting GetPainting()
        {
            if (paintings == null)
                loadPaintings();
            return paintings.FirstOrDefault();
        }

        public Painting GetPaintingById(int id)
        {
            if (paintings == null)
                loadPaintings();
            return paintings.Where(p=>p.PaintingId == id).FirstOrDefault();
        }

        public List<Painting> GetPaintings()
        {
            if (paintings == null)
                loadPaintings();
            return paintings;
        }

        public void UpdatePainting(Painting painting)
        {
            Painting paintingToUpdate = paintings.Where(p => p.PaintingId == painting.PaintingId).FirstOrDefault();
            paintingToUpdate = painting;
        }

        private void loadPaintings()
        {
            paintings = new List<Painting>()
            {
                new Painting(1)
                {
                    PaintingName = "Mendocino Moment",
                    Description = "Quaint architecture of Mendocino, California, as seen by the artist while on a road trip. ",
                    AmountInStock = 2,
                    InStock = true,
                    FirstAquired = new DateTime(2014, 1, 3),
                    ArtistName = Artist.JoyceHicks,
                    Price = 1500,
                    IsPaintingSelected = false

                },

                new Painting(2)
                {
                    PaintingName = "Winter Snowscape",
                    Description = "Quaint little town covered in the first snow of winter in Russia",
                    AmountInStock = 3,
                    InStock = true,
                    FirstAquired = new DateTime(2014, 5, 9),
                    ArtistName = Artist.BillVrscak,
                    Price = 1460,
                    IsPaintingSelected = false

                },

            };
        }
    }
}
