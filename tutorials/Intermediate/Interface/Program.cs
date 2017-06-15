using System;
using System.IO;

namespace Extensibility {


  class Program
  {
    static void Main(string[] args)
    {
        var dbMigrator = new DbMigrator(new FileLogger("E:\\desktop\\log.txt"));
        dbMigrator.Migrate();
    }
  }
}
