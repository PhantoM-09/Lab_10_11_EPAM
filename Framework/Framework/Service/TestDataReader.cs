using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Framework.Service
{
    class TestDataReader<T>
    {
        public static T GetInfoFromFile(string filePath)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(filePath));
        }
    }
}
