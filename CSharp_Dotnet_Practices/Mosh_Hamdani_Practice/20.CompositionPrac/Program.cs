using System;

namespace CompositionPrac
{
    class Program
    {
        static void Main(string[] args)
        {
             var dbmigrator = new DbMigrator(new logger());

             var logger1 = new logger();
             var installer = new Installer(logger1);

             dbmigrator.Migrate();
             installer.Install();

        }
    }
}
