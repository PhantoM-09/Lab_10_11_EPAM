using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Service
{
    class UserCreator
    {
        private static readonly string _filePath = "../../../Resources/User.json";

        public static User CreateUserWithCredentialsFromProperty()
        {
            return TestDataReader<User>.GetInfoFromFile(_filePath);
        }
    }
}
