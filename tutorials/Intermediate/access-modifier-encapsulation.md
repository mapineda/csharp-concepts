In this tutorial we will learn about encapsulation.

Ex:

```
using System;

namespace AccessModifiers {
        public class Report
        {

          private DateTime _reportDeadline

          public void SetDeadline(DateTime deadline)
          {
            _reportDeadline = deadline;
          }

          public DateTime GetBirthdate();
          {
            return _reportDeadline;
          }
        }

        class Program
        {
          static void Main(string[] args)
            var report = new Report();

            report.SetDeadline()


        }

}

```
