using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

//Add reference to System.Web if not yet referenced
using System.Web;
using System.Web.Configuration;

namespace PassportCommon
{
    public abstract class Configuration
    {
        public static String ConnectionString
        {
            get
            {
                //return WebConfigurationManager.AppSettings["Conn"];
                return ConfigurationManager.ConnectionStrings["HPSCDBNEW"].ConnectionString;
            }
        }

        //public static Double MaintainingBalance
        //{
        //    get
        //    {
        //        return Convert.ToDouble(WebConfigurationManager.AppSettings["MaintainingBalance"]);
        //    }
        //}
    }
}

