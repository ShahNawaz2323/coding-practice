namespace CompositionPrac
{
    public class DbMigrator
    {
        private readonly logger _logger;
        public DbMigrator(logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah...");
        }
    }
}
