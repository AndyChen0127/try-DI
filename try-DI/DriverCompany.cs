using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_DI
{
    public class DriverCompany
    {
        private readonly IDriver _driver;

        // 建構注入
        public DriverCompany(IDriver driver)
        {
            if (driver == null)
                throw new ArgumentNullException("driver為空");
            this._driver = driver;
        }

        public void ShowDriver() 
        {
            this._driver.ShowInformation();
        }
    }
}
