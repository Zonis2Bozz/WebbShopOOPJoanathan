using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebbShopOOPJoanathan.DataSource;

namespace WebbShopOOPJoanathan.Pages
{
    public class Index1Model : PageModel
    {

        private readonly IDataSource _dataSource;
        public List<Produkt> Produkts { get; set; }

        public Index1Model(IDataSource dataSource)
        {
            _dataSource = dataSource;
            Produkts = _dataSource.GetAll();
        }


        public void OnGet()
        {
        }
    }
}
