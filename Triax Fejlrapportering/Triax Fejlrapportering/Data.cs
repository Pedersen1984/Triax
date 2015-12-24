using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triax_Fejlrapportering
{
    public class Data
    {
        public string Name { get; set; }
        public DateTime RepDate { get; set; }
        public double RepTime { get; set; }
        public int StockNumber { get; set; }
        public string Fault { get; set; }
        public string PositionNumber { get; set; }
        public int ComponentStockNumber { get; set; }
        public string Notes { get; set; }
        public string ComponentValue { get; set; }
    }

    public class Products
    {
        public string ComponentTopPath { get; set; }
        public int StockNumber { get; set; }
        public string ComponentBotPath { get; set; }
        public string DiagramPath { get; set; }
        public string RefPath { get; set; }
        public int ValueCol { get; set; }
        public int ComponentStockNumber { get; set; }
        public int PlacementCol { get; set; }
        public string ProductName { get; set; }
        public int StartRow { get; set; }
        public string Stockfold { get; set; }
        public string PCBfold { get; set; }
        public string Dianame { get; set; }
        public string Refname { get; set; }
        public string Comptop { get; set; }
        public string Compbot { get; set; }

        public Products(string name, int placcol, int compstocknr, int valcol, string stockfolder, string reff, string dia, string PCBfolder, string comptop, int stocknr, string compbot, int startrow)
        {
            ComponentBotPath = PCBfolder + @"\" + compbot;
            ComponentStockNumber = compstocknr;
            ComponentTopPath = PCBfolder + @"\" + comptop;
            DiagramPath = stockfolder + @"\" + dia;
            PlacementCol = placcol;
            ProductName = name;
            RefPath = stockfolder + @"\" + reff;
            StockNumber = stocknr;
            ValueCol = valcol;
            StartRow = startrow;
            PCBfold = PCBfolder;
            Stockfold = stockfolder;
            Compbot = compbot;
            Comptop = comptop;
            Dianame = dia;
            Refname = reff;
        }
    }
}
