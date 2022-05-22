namespace CompositionPrac
{
    public class Installer
    {
        private readonly logger _logger;
        public Installer(logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We are Installing the application.");
        }
    }
}
