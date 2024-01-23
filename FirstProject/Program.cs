using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           ExcelFile excelFile = new ExcelFile();
           
           excelFile.CreatedOn = DateTime.Now;
           excelFile.FileName = "excel-file";
           
           excelFile.GenerateReport();

           WordDocumentFile wordDocumentFile = new WordDocumentFile();
        
           wordDocumentFile.CreatedOn = DateTime.Now;
           wordDocumentFile.FileName = "word-file";
           
           wordDocumentFile.Print();
        }
    }
}
