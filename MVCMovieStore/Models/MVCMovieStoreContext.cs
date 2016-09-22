using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMovieStore.Models
{
    public class MVCMovieStoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCMovieStoreContext() : base("name=MVCMovieStoreContext")
        {
        }

        public System.Data.Entity.DbSet<MVCMovieStore.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MVCMovieStore.Models.Review> Reviews { get; set; }
    
    }
}
