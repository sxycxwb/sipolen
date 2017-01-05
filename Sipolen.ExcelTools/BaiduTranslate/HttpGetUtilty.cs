using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sipolen.ExcelTools.BaiduTranslate
{
    public class HttpGetUtilty
    {
        /// <summary>  
        /// GET请求与获取结果  
        /// </summary>  
        public static string HttpGet(string url, Dictionary<string, string> dict)
        {
            if (dict == null)
            {
                return url;
            }
            StringBuilder builder = new StringBuilder(url);
            if (url.Contains("?"))
            {
                builder.Append("&");
            }
            else
            {
                builder.Append("?");
            }

            int i = 0;
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                string value = kvp.Key;
                if (value == null)
                { // 过滤空的key
                    continue;
                }

                if (i != 0)
                {
                    builder.Append('&');
                }

                builder.Append(kvp.Key);
                builder.Append('=');
                builder.Append(kvp.Key == "q" ? UrlEncode(kvp.Value) : kvp.Value);//将q进行编码

                i++;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(builder.ToString());
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        private static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
    }
}
