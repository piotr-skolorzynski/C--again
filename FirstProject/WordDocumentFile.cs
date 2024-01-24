using System;

namespace FirstProject;
public class WordDocumentFile : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }
    public void Print() => Console.WriteLine($"{ FileName } printing... ");
    public void Compress() => Console.WriteLine("Compressing WordDocumentFile");
}
