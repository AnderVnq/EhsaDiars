using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CapaLogica
{
    public class ConsultaAPI
    {

        public dynamic get(string url)
        {
            try
            {
                HttpWebRequest MyWebRequest = (HttpWebRequest)WebRequest.Create(url);
                MyWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                MyWebRequest.Credentials = CredentialCache.DefaultCredentials;
                MyWebRequest.Proxy = null;

                using (HttpWebResponse httpResponse = (HttpWebResponse)MyWebRequest.GetResponse())
                {
                    using (Stream stream = httpResponse.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(stream))
                        {
                            string datos = HttpUtility.HtmlDecode(sr.ReadToEnd());
                            dynamic data = JsonConvert.DeserializeObject(datos);
                            return data;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)ex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string errorText = reader.ReadToEnd();
                            dynamic errorData = JsonConvert.DeserializeObject(errorText);
                            return errorData;
                        }
                    }
                }
                throw;
            }
        }


    }
    
}
