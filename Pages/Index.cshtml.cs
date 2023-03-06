using BakeryApp.Data;
using BakeryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /*public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }*/

        private readonly BakeryContext db;
        public IndexModel(BakeryContext db) => this.db = db;
        public List<Product> Products { get; set; } = new List<Product>();
        public Product FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}
