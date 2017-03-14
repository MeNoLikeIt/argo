using System.Data.Entity;
using Argo.dal.Migrations;

namespace Argo.dal
{
    public class DbInitializer : MigrateDatabaseToLatestVersion<ArgoDatabase, Configuration>
    {

    }
}
