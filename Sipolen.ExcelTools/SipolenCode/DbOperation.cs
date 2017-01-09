using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipolen.ExcelTools.SipolenCode
{
    public class DbOperation
    {
        public void ImportNodeDict(DataTable dictTable)
        {
            var sqlList = new ArrayList();
            foreach (DataRow row in dictTable.Rows)
            {
                var insertSql = string.Empty;

                string nodeId = row["NODEID"].ToString().Replace("'","");
                string nodeName = row["NODENAME"].ToString().Replace("'", "");
                string nodeDesc = row["NODEDESC"].ToString().Replace("'", "");
                string country = row["COUNTRY"].ToString().Replace("'", "");
                string category = row["CATEGORY"].ToString().Replace("'", "");

                insertSql = $"INSERT INTO S_NODEDICT(NODEID,NODENAME,NODEDESC,COUNTRY,CATEGORY) VALUES('{nodeId}','{nodeName}','{nodeDesc}','{country}','{category}');";

                sqlList.Add(insertSql);
            }
            SqlHelper.ExecuteSqlTran(sqlList);
        }
    }
}
