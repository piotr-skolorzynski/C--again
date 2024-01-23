using System;

namespace FirstProject;
public class ExcelFile : File // dziedziczenie po klasie File
{
    public void GenerateReport() => Console.WriteLine($"{ FileName } report... ");
}
