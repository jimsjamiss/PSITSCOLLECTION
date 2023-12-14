using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCollection.AppData;

namespace VSCollection.Model
{
    internal class UserLogged
    {
        private static UserLogged _instance;

        public Officer officer { get; set; }
        public Admin admin { get; set; }

        private UserLogged()
        {

        }


        public static UserLogged GetInstance()
        {
            if (_instance == null)
                _instance = new UserLogged();
            return _instance;
        }
    }
}
