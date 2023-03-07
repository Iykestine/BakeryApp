using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryApp.Data;
using BakeryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BakeryApp.Pages
{
    public class OrderModel : PageModel
    {
        private BakeryContext db;
        public OrderModel(BakeryContext db) => this.db = db;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Product Product { get; set; }
        public async Task OnGetAsync() => Product = await db.Products.FindAsync(Id);
    }
    
}
