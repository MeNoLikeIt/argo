using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argo.dal.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ArgoDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            CommandTimeout = 60 * 5;
        }

        protected override void Seed(ArgoDatabase context)
        {
            base.Seed(context);
        }
    }
}
