using System;

namespace FirstProject;
public class ExcelFile : IFile // implementacja interfejsu, kolejne deklaruje się po przecinku
{
    //wadą implenetacji interfejsu jest to że trzeba zadeklarować zmienne w przeciwieństwie do
    // dziedziczenia po klasie
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }

    public void GenerateReport() => Console.WriteLine($"{ FileName } report... ");

    // przy implementacji interfejsu nie trzeba słówka override
    public void Compress() => Console.WriteLine("Compressing ExcelFile");
}
