using System;
using Newtonsoft.Json;

namespace CsharpHttpHelper.Helper
{
	internal class JsonHelper
	{
		internal static object JsonToObject<T>(string jsonstr)
		{
			object result;
			try
			{
                result = JsonConvert.DeserializeObject(jsonstr);
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		internal static string ObjectToJson(object obj)
		{
			string result;
			try
			{

			    result = JsonConvert.SerializeObject(obj);
			}
			catch (Exception)
			{
				result = string.Empty;
			}
			return result;
		}
	}
}
