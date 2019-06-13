using Panda.Data;
using SIS.MvcFramework;
using SIS.MvcFramework.DependencyContainer;
using SIS.MvcFramework.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panda.Web
{
    public class Startup : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var db = new PandaDbContext())
            {
                db.Database.EnsureCreated();
            }
        }


        public void ConfigureServices(SIS.MvcFramework.DependencyContainer.IServiceProvider serviceProvider)
        {
            //throw new NotImplementedException();
        }
    }
}
