using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sipolen.ExcelTools.BaiduTranslate
{
    public class TransApi
    {
        private static int appidSecurityIndex = 0;
        private string appid;
        private string securityKey;
        private const string TRANS_API_HOST = "http://api.fanyi.baidu.com/api/trans/vip/translate";
        private Dictionary<string, string> appidSecurityKeyDict = new Dictionary<string, string>() { { "20170104000035221", "R6KiPxXVShiu9huQfsdU" } };


        public string getTransResult(string query, string from, string to)
        {

            string key = GetAppidAndSecurityKey();
            this.appid = key.Split('|')[0];
            this.securityKey = key.Split('|')[1];

            var dict = buildParams(query, from, to);
            string transResult = HttpGetUtilty.HttpGet(TRANS_API_HOST, dict);

            //如果返回结果中有异常
            if (transResult.Contains("error_code"))
            {

            }
            //{"error_code":"54001","error_msg":"Invalid Sign"}
            return transResult;
        }

        private string GetAppidAndSecurityKey()
        {
            int i = 0;
            string resultStr = string.Empty;
            foreach (KeyValuePair<string, string> kvp in appidSecurityKeyDict)
            {
                if (i == appidSecurityIndex)
                    resultStr = kvp.Key + "|" + kvp.Value;
                i++;
            }
            return resultStr;
        }

        private Dictionary<string, string> buildParams(string query, string from, string to)
        {
            Dictionary<String, String> dict = new Dictionary<String, String>();
            dict.Add("q", query);
            dict.Add("from", from);
            dict.Add("to", to);
            dict.Add("appid", appid);

            // 随机数
            string salt = DateTime.Now.Millisecond.ToString();
            dict.Add("salt", salt);

            // 签名
            string src = appid + query + salt + securityKey; // 加密前的原文
            src = get_uft8(src);//utf-8编码
            dict.Add("sign", Md5Encrypt32(src));

            return dict;
        }

        private static string get_uft8(string unicodeString)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(unicodeString);
            string msg = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            return msg;
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        private static string Md5Encrypt32(string myString)
        {
            string retStr;
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();

            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;

            //使用GB2312编码方式把字符串转化为字节数组．
            inputBye = Encoding.GetEncoding("utf-8").GetBytes(myString);

            outputBye = m5.ComputeHash(inputBye);

            retStr = System.BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToLower();
            return retStr;
        }
    }
}
