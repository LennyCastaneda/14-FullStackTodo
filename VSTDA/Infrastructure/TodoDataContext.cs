using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VSTDA.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("MyTodoDatabase")
        {
            //  DbContext will not load child objects for some parent object unless Include method is called on parent object
            //  If DbContext.Configuration.ProxyCreationEnabled is set to false, DbContext will not load child objects for some parent object unless Include method is called on parent object.Setting DbContext.Configuration.LazyLoadingEnabled to true or false will have no impact on its behaviours.
            //  If DbContext.Configuration.ProxyCreationEnabled is set to true, child objects will be loaded automatically, and DbContext.Configuration.LazyLoadingEnabled value will control when child objects are loaded.
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<VSTDA.Models.Todo> Todoes { get; set; }
    }
}