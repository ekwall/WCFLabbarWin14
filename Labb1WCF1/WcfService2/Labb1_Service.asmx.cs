using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfService2
{
    /// <summary>
    /// Summary description for Labb1_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Labb1_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddTwoNumbers(int x, int y)
        {
            return x+y;
        }
    }
}
