using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace Triax_Fejlrapportering
{
    class MyExcel
    {
        public static string DB_PATH = @"";

        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static Excel.Range rng = null;
        private static int lastRow=0;
        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        public static string[] ReadFromExcel(int compStock, int compval, int compplacecol, int startrow, string compplace )
        {
            List<string> outputs = new List<string>();
            for (int i = startrow; i <= lastRow; i++)
			{
                rng = (Excel.Range)MySheet.Cells[i, compplacecol];
                if (string.Equals(rng.Value,compplace))
                {
                    rng = (Excel.Range)MySheet.Cells[i, compStock];
                    outputs.Add(rng.Value);
                    rng = (Excel.Range)MySheet.Cells[i, compval];
                    outputs.Add(rng.Value);
                    break;
                }
			}
            
            string[] output = outputs.ToArray();
            return output;
        }

        public static string[] ReadFromExcel(string compplace, int startrow, int compplacecol)
        {
            List<string> outputs = new List<string>();
            for (int i = startrow; i <= lastRow; i++)
            {
                rng = (Excel.Range)MySheet.Cells[i, compplacecol];
                outputs.Add(rng.Value);
            }
            string[] output = outputs.ToArray();
            return output;
        }

        public static void WriteToExcel(Data emp)
        {
            try
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 1] = emp.Name;
                MySheet.Cells[lastRow, 2] = emp.RepTime;
                MySheet.Cells[lastRow, 3] = emp.RepDate;
                MySheet.Cells[lastRow, 4] = emp.StockNumber;
                MySheet.Cells[lastRow, 6] = emp.Fault;
                MySheet.Cells[lastRow, 7] = emp.PositionNumber;
                MySheet.Cells[lastRow, 8] = emp.ComponentStockNumber;
                MySheet.Cells[lastRow, 9] = emp.Notes;
                MyBook.Save();
            }
            catch (Exception ex)
            { }
            

        }

        
        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }
        
    }
    
}
