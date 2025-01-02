using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Supermarket_mangement
{
    class Connection
    {
        public static string username="EM" , password="EM";
        static public string con = @"Provider=MSDAORA;Data Source=Abdullah;User ID="+username+";Password="+password+";";

        public static string changed = "";
            }
       
    }
