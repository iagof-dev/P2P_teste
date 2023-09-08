using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_teste
{
    public class preferencias
    {
        public static bool server_started = false;
        public static string user_name { get; set; }
        public static string server_ip { get; set; }
        public static int server_port { get; set; }
    }
}
