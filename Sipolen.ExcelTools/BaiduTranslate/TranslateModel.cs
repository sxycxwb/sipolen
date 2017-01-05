using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipolen.ExcelTools.BaiduTranslate
{
    public class TranslateSuccessResult
    {

    }

    public class TranslateErrorResult
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public string error_code { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string error_msg { get; set; }
    }
}
