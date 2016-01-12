using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfService1
{
    /// <summary>
    /// Summary description for myFirstService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class myFirstService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetTomorrowsWheater(string dayOfWeek)
        {
            dayOfWeek = dayOfWeek.FirstLetterUpper();
            var rndNum = GetRandomNumber(0, 4);
            switch (rndNum)
            {
                case 0:
                    return dayOfWeek + " Gonna be clouded and smell like fish all mornin. Kepp yerself inside!";
                    break;
                case 1:
                    return dayOfWeek + " Gonna sun sun sunny. Put yet lotion on. Vampires better stay inside.";
                    break;
                case 2:
                    return dayOfWeek + " Rain! rainrainrain! Put yer boots on!";
                    break;
                case 3:
                    return dayOfWeek + " gonna be smoggy! Smookiiiiiiinnnn";
                    break;
                case 4:
                    return dayOfWeek + " ooh today is bad weather! Don't get out of bed!";
                    break;
                default:
                    return "No wheater for you";
                    break;
            }

            return "Hello World";
        }

        

        public int GetRandomNumber(int minValue, int maxValue)
        {
            var rnd = new Random();
            var returnValue = rnd.Next(minValue, maxValue);

            return returnValue;
        }
    }

    public static class ExtensionMethods
    {
        public static string FirstLetterUpper(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            else
            {
                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }
        }
    }

}
