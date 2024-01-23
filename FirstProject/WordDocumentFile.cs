using System;

namespace FirstProject;
public class WordDocumentFile : File
{
    public void Print() => Console.WriteLine($"{ FileName } printing... ");
    public override void Compress() => Console.WriteLine("Compressing WordDocumentFile");
}
