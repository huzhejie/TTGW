using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Text.RegularExpressions;
namespace TTG.DAL.READ
{
    public class read_excel
    {
        public IWorkbook workbook;
        public ISheet sheet;

        /// <summary>
        /// 初始化，读取路径为path的文件。
        /// </summary>
        /// <param name="path"></param>
        public void init(string path)
        {
            FileStream fs = File.OpenRead(path);
            workbook = WorkbookFactory.Create(fs);
            sheet = workbook.GetSheetAt(0);
            fs.Close();
        }
        /// <summary>
        /// 读取第row行，第column列的数据
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>object</returns>
        public object readcell(int row, int column)
        {

            IRow ir = sheet.GetRow(row);
            ICell ic = ir.GetCell(column);
            object value = null;
            try
            {
                if (DateUtil.IsCellDateFormatted(ic))
                    value = ic.DateCellValue;
                else
                    value = ic.NumericCellValue;
            }
            catch (Exception)
            {
                try
                {
                    value = ic.DateCellValue;
                }
                catch (Exception)
                {
                    try
                    {
                        value = ic.StringCellValue;
                    }
                    catch (Exception)
                    {
                        throw new Exception("读取错误");
                    }
                }
            }
            return value;
        }
        /// <summary>
        /// 返回excel表的最大行号
        /// </summary>
        /// <returns></returns>
        public int getMaxRow()
        {
            return sheet.LastRowNum;
        }
        /// <summary>
        /// 返回row行column列的单元格横跨几列
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public int getSpanNum(int row, int column)
        {
            ICell cell = sheet.GetRow(row).GetCell(column);
            if (cell == null)
            {
                return -1;
            }
            else
            {
                if (!cell.IsMergedCell)
                    return 1;
                else
                {
                    int colSpan = 1;
                    cell = sheet.GetRow(row).GetCell(++column);
                    while (cell != null)
                    {
                        //Console.WriteLine(cell.ToString());
                        colSpan++;
                        column++;
                        if (column > sheet.GetRow(row).LastCellNum)
                            break;
                        cell = sheet.GetRow(row).GetCell(column);
                    }
                    return colSpan;
                }
            }
        }
        /// <summary>
        /// 返回某一行最大列号
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int getMaxColNum(int row)
        {
            return sheet.GetRow(row).LastCellNum;
        }
        /// <summary>
        /// 获取第row行第column列的单元格横跨行数
        /// </summary>
        /// <param name="row">行号</param>
        /// <param name="column">列号</param>
        /// <returns>横跨行数</returns>
        public int getSpanRows(int row, int column)
        {
            int start = row;
            int maxrow = sheet.LastRowNum;
            while (row < maxrow)
            {
                try
                {
                    string value = sheet.GetRow(++row).GetCell(column).StringCellValue;
                    if (!value.Equals(""))
                        break;
                }
                catch
                {
                    break;
                }
            }
            return row - start;
        }

        public string replaceBlank(string str)
        {                            
            return Regex.Replace(str,@"\s+","");
        }
    }
}
