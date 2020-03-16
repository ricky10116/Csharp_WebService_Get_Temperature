using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WindowsFormsApplication_GetTemperature
{
    class GetTemMethod
    {
        public string GetTemMethodtemp(string city)
        {
            string sURL,sURL1,sURL2;
            sURL1 = "https://weather.cit.api.here.com/weather/1.0/report.json?product=observation&name=";
            sURL2 = "&app_id=DemoAppId01082013GAL&app_code=AJKnXv84fjrb0KIHawS0Tg";
            sURL = sURL1 + city + sURL2;
            
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            WebProxy myProxy = new WebProxy("myproxy", 80);
            myProxy.BypassProxyOnLocal = true;

            wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int start = 0;
            int end = 0;
            //int i = 0;
            sLine = objReader.ReadToEnd();
            start = sLine.LastIndexOf(",\"temperature\":\"");   //   ,"temperature":"  ,\"temperature\":\"
            sLine = sLine.Substring(start + 16);
            end = sLine.LastIndexOf("\",\"tem");
            sLine = sLine.Substring(0, end);        //   \",\"tem

            return sLine;
        }
            
    }
}
