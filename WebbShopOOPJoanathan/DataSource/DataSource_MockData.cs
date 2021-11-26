using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbShopOOPJoanathan.DataSource
{
    public class DataSource_MockData:IDataSource
    {
        public List<Produkt> Movies { get; set; }
        public DataSource_MockData()
        {
            Movies = new List<Produkt>()
            {
                new Produkt()
                {
                    ProduktId = Guid.NewGuid(),
                    produktName = "The Shining",
                    ImgUrl = "https://pics.filmaffinity.com/the_shining-453129380-large.jpg"
                }
            };
        }

        public List<Produkt> GetAll()
        {
            return Movies;
        }
    }
}
