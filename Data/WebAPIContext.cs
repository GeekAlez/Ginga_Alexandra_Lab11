using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ginga_Alexandra_Lab11.Models;

namespace Ginga_Alexandra_Lab11.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Ginga_Alexandra_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
