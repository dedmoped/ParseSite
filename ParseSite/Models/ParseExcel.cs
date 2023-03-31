using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseSite.Models
{
    class ParseExcel
    {
        WorkBook _wb; 
        public ParseExcel(string path)
        {
            _wb = WorkBook.Load(path);

        }
        public string ParseData(string SheetName)
        {
            List<Cell[]> cells = new List<Cell[]>();
            WorkSheet ws = _wb.GetWorkSheet("Лист1");
            for (int i = 4; i < ws.RowCount; i++)
            {
                cells.Add(ws[$"B{i}:J{i}"].ToArray());
            }
            return "";
        }
        
    }
}
