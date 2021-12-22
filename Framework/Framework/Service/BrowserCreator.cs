using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Service
{
    class BrowserCreator
    {
        private static readonly string _filePath = "../../../Resources/Browser.json";

        public static Browser CreateBrowser()
        {
            return TestDataReader<Browser>.GetInfoFromFile(_filePath);
        }
    }
}
