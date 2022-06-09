using System;

namespace InterfacesExtensibilit
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration Statrted at : " + DateTime.Now);
           
           //Details of migration the database

           _logger.LogInfo("Migration Finished at : " + DateTime.Now);
           
        }
    }
}
