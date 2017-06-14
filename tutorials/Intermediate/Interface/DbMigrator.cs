using System;

namespace Extensibility
{

  public class DbMigrator
  {
    private readonly Ilogger _logger;

    public DbMigrator(ILogger logger)
    {
      _logger = logger;
    }


    public void Migrate()
    {
      //details of migrating the database
      _logger.LogInfo("Migration started at {0} " + DateTime.Now);

      _logger.LogInfo("Migration finished at {0} " + DateTime.Now);
    }
  }
}
