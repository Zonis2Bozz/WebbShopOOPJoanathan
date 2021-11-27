using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbShopOOPJoanathan.DataSource;

namespace WebbShopOOPJoanathan.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDataSource _dataSource;
        public List<Produkt> Produkts { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IDataSource dataSource)
        {
            _logger = logger;
            _dataSource = dataSource;
            Produkts = _dataSource.GetAll();
        }

        public void OnGet()
        {

        }
    }
}
