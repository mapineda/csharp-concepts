using System:

namespace Compostion
{

  public class Installer
  {
    private readonly Logger _logger

    public Install(Logger logger)
    {
      _logger= logger;
    }

    public void Install()
    {
      _logger.Log("Instaling the application");
    }
  }

}
