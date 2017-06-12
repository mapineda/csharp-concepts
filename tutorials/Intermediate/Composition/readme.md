
Step 1.

```
using System;


namespace Composition
{
  public class Logger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

    }


  }
}
```

Step 2. Create a file called Logger.cs. Copy and paste the logger method from Program.cs into Logger.cs .
Step 3. Create a DbMigrator class.

```
//step 1


using System;


namespace Composition
{

  public class DbMigrator
  {
    private readonly Logger _logger;

    public DbMigrator(Logger logger)
    {
      _logger = logger;
    }

    public void Migrate()
    {
      _logger.Log("Migrating in progress......pinging.....connecting....");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

    }
  }
}

```

Step 4. Create a file called DbMigrator and copy paste the DbMigrator class from Program.cs.


Step 5. Create a Installer.cs file and create a Installer class with an Install method.

```

```

Step 6.

```
using System;


namespace Composition
{
  class Program
  {
    static void Main(string[] args)
    {
      var dbMigrator = new DbMigrator(new Logger());
      var logger = new Logger();
      var installer = new Installer(logger);

      dbMigrator.Migrate();
      installer.Install();

    }
  }
}


```

Step 7. Run the application.
