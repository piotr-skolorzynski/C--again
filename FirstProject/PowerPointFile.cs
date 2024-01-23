using System;

namespace FirstProject;
public class PowerPointFile : File
{
    public void Present() => Console.WriteLine($"{ FileName } presenting... ");
    public override void Compress() => Console.WriteLine("Compressing PowerPointFile");
}
