using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Sipolen.ExcelTools
{
    /// <summary>
    /// SipolenExcel 操作类
    /// </summary>
    public static class SipolenExcelUtility
    {
        public static DataTable MoveDataTable(DataTable sourceDt, DataTable targetDt)
        {
            if (sourceDt != null && sourceDt.Rows.Count > 0)
            {
                for (int i = 0; i < sourceDt.Rows.Count; i++)
                {
                    DataRow sourceDr = sourceDt.Rows[i];

                    DataRow targetDr = targetDt.NewRow();
                    for (int j = 0; j < targetDt.Columns.Count; j++)
                    {
                        var col = targetDt.Columns[j];
                        var colName = col.ColumnName;
                        
                        //判断目标中的列名是否在原表中存在，如果存在就把值取出来
                        if (sourceDt.Columns.Contains(colName))
                        {
                            var sourceColValue = sourceDr[colName];
                            targetDr[colName] = sourceColValue;
                        }
                    }
                    targetDt.Rows.Add(targetDr);
                }
            }
            return targetDt;
        }




        #region HandleExcel

        /// <summary>
        /// 利用模板，DataTable导出到Excel（单个类别）
        /// </summary>
        /// <param name="dtSource">DataTable</param>
        /// <param name="targetExcelPath">目标路径</param>
        /// <param name="sheetName">Excel Sheet名称</param>
        /// <returns></returns>
        public static void ExportExcelFromDt(DataTable dtSource, string targetExcelPath,string sheetName)
        {

            #region 处理DataTable

            #endregion
            int totalIndex = 20;        // 每个类别的总行数
            int rowIndex = 3;           // 起始行
            int dtRowIndex = dtSource.Rows.Count;       // DataTable的数据行数

            FileStream file = new FileStream(targetExcelPath, FileMode.Open, FileAccess.Read);//读入excel模板
            HSSFWorkbook workbook = new HSSFWorkbook(file);

            ISheet sheet = workbook.GetSheet(sheetName);

            foreach (DataRow row in dtSource.Rows)
            {
                #region 填充内容
                IRow dataRow = sheet.CreateRow(rowIndex);

                int columnIndex = 0;        // 开始列（0为标题列，从1开始）
                foreach (DataColumn column in dtSource.Columns)
                {
                    // 列序号赋值
                    if (columnIndex >= dtSource.Columns.Count)
                        break;

                    ICell newCell = dataRow.GetCell(columnIndex);
                    if (newCell == null)
                        newCell = dataRow.CreateCell(columnIndex);

                    string drValue = row[column].ToString();

                    switch (column.DataType.ToString())
                    {
                        case "System.String"://字符串类型
                            newCell.SetCellValue(drValue);
                            break;
                        case "System.DateTime"://日期类型
                            DateTime dateV;
                            DateTime.TryParse(drValue, out dateV);
                            newCell.SetCellValue(dateV);

                            break;
                        case "System.Boolean"://布尔型
                            bool boolV = false;
                            bool.TryParse(drValue, out boolV);
                            newCell.SetCellValue(boolV);
                            break;
                        case "System.Int16"://整型
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intV = 0;
                            int.TryParse(drValue, out intV);
                            newCell.SetCellValue(intV);
                            break;
                        case "System.Decimal"://浮点型
                        case "System.Double":
                            double doubV = 0;
                            double.TryParse(drValue, out doubV);
                            newCell.SetCellValue(doubV);
                            break;
                        case "System.DBNull"://空值处理
                            newCell.SetCellValue("");
                            break;
                        default:
                            newCell.SetCellValue("");
                            break;
                    }
                    columnIndex++;
                }
                #endregion

                rowIndex++;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                sheet = null;
                workbook = null;
                //sheet.Dispose();
                //workbook.Dispose();//一般只用写这一个就OK了，他会遍历并释放所有资源，但当前版本有问题所以只释放sheet
                FileStream fs = new FileStream(targetExcelPath, FileMode.OpenOrCreate);
                BinaryWriter w = new BinaryWriter(fs);
                w.Write(ms.ToArray());
                fs.Close();
                ms.Close();
            }
        }

        #endregion
    }
}
