using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_DI
{
    public class DriverA : IDriver
    {
        public void ShowInformation()
        {
            Console.WriteLine("駕駛A");
        }
    }
}
