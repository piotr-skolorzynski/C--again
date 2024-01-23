using System;

namespace FirstProject;
public abstract class File
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }

    // narzuca każdej dziedziczącej klasie konieczność
    // implementacji metody Commpress. Mogą różnić się w mięsku. Nie ma to znaczenia
    public abstract void Compress();
}
