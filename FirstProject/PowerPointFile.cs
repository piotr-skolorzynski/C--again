using System;

namespace FirstProject;
public class PowerPointFile : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }
    public void Present() => Console.WriteLine($"{ FileName } presenting... ");
    public void Compress() => Console.WriteLine("Compressing PowerPointFile");
}
