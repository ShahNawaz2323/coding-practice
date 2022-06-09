namespace InterfacesExtensibilit
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("D:\\log.text"));
            dbMigrator.Migrate();
        }
    }
}
