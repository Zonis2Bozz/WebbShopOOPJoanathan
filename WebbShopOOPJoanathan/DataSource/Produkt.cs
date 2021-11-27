using System;

namespace WebbShopOOPJoanathan.DataSource
{
    public class Produkt
    {
        public Guid ProduktId { get; set; }
        public string produktName { get; set; }
        public string ImgUrl { get; set; }
        public int price { get; set; }
    }
}