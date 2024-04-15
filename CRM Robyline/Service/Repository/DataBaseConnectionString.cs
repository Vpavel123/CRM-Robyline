using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Robyline.Service.Repository
{
    class DataBaseConnectionString
    {
        public static DataBaseConnectionString Inst { get; private set; }
        static DataBaseConnectionString() 
        {
            Inst = new DataBaseConnectionString();
        }

        public string Set() 
        {
            return "server = localhost; port=3306; user = robyline_admin; password = Admin123Admin; database = robyline_Db";
        }
    }
}
