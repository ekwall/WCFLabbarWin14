using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WcfService6_2
{
    /// <summary>
    /// Summary description for Labb6_2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Labb6_2 : System.Web.Services.WebService
    {

        public List<string> contriesList;

        public Labb6_2()
        {
             contriesList = new List<string>();   
        }
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<string> GetCountries(string search)
        {
            XmlTextReader reader = new XmlTextReader(@"C:\GitProjects\WCF\labbar\WCFLabbarWin14\Labb1WCF1\WcfService6_2\countries.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    contriesList.Add(reader.Value);
                }
            }

            var test = contriesList.FindAll(x => x.Contains(search));

            var test2 = contriesList.OrderByDescending(x => x).ToList();

            var result = (
                from c in contriesList
                where c.Contains(search)
                select c).ToList();

            return test2;
        } 
    }
}
