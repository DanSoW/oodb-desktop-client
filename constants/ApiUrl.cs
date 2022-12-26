using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb_desktop_client.constants
{
    public class ApiUrl
    {
        static public string BASE_URL = "https://localhost:7095";
        static public string PERST_DOMAIN = "/api/perst";
        static public string DB4O_DOMAIN = "/api/db40";

        static public string GET = "/get";
        static public string GET_ALL = "/get/all";
        static public string SAVE = "/save";
        static public string DELETE = "/delete";
        static public string UPDATE = "/update";

        static public string ADMIN = "/admin";
        static public string HOST = "/host";
        static public string MONITOR_APP = "/monitor-app";
        static public string HOST_SERVICE = "/host-service";
        static public string SERVICE = "/service";
        static public string DATA_SOURCE = "/data-source";
    }
}
