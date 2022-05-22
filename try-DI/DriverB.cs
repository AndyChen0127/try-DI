using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_DI
{
    public class DriverB : IDriver
    {
        public void ShowInformation()
        {
            Console.WriteLine("駕駛B");
        }
    }
}
