using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;

namespace WcfService5
{
    /// <summary>
    /// Summary description for Labb1_5Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Labb1_5Service : System.Web.Services.WebService
    {
        
        //<DateTime, List<string>>
        

        [WebMethod]
        public string GetDateOfNamesDay(string name)
        {
            var dateDict = new Dictionary<DateTime, List<string>>();

            string text = System.IO.File.ReadAllText( @"~/WcfService5/Namnsdagar.txt" );
            string numberPattern = @"[0-9]{1,2}[ ]{1}[0-9]{1,2}[ ]{1}";
            string separateCarrigeReturn = @"[\n\r]+";
            var myregex = new Regex("1-9,0-9,␣,1-9,0-2,␣");

            string[] splitAtDates = Regex.Split(text, separateCarrigeReturn);

            

            var selectedNames = (

                from s in splitAtDates
                where s.ToLower().Contains(name.ToLower())
                select s).ToList();



            foreach (var s in selectedNames)
            {

                var theDateString = Regex.Split(s, @"[A-ö]");
                var dateStringSplitted = theDateString[0].Split(' ');
                var theDate = new DateTime(2016, Int32.Parse(dateStringSplitted[1]), Int32.Parse(dateStringSplitted[0]));
                var splitted = Regex.Split(s, numberPattern);
                var splitNames = Regex.Split((splitted[1]), "[ ,]{1-2}").ToList();

                dateDict.Add(theDate, splitNames);

              

            }

            var result = (
                from d in dateDict
                from e in d.Value
                where Regex.IsMatch(e.ToLower(), @"\b" + name.ToLower() + @"\b")
                    select d.Key
                    ).FirstOrDefault();

            return result.ToString("MMMM dd");

        }

        [WebMethod]
        public List<string> GetDatesOfNamesDay(string name)
        {
            string text = System.IO.File.ReadAllText(@"C:\GitProjects\WCF\labbar\WCFLabbarWin14\Labb1WCF1\WcfService5\Namnsdagar.txt");
            string thePattern = @"[1-9,␣,1-9,␣]";
            string separateCarrigeReturn = @"[\r]";
            var myregex = new Regex("1-9,0-9,␣,1-9,0-2,␣");

            string[] splitAtDates = Regex.Split(text, separateCarrigeReturn);








            var test = (

                from s in splitAtDates
                where s.ToLower().Contains(name.ToLower())
                select s).ToList();

            //if (string.IsNullOrEmpty(test))
            //{
            //    return new List<string>() { "Naj det blev fel" };
            //}


            return test;



        }

        public void SetTextfileAsList()
        {
            
        }
    }
}
