using System;

namespace FirstProject;
public interface IFile
{
    //usunąłem public i dla metody Compress również abstract 
    //ponieważ wszystkie pola w interfejsach są public i abstract domyślnie
    string FileName { get; set; }
    int Size { get; set; }
    DateTime CreatedOn { get; set; }

    // narzuca każdej dziedziczącej klasie konieczność
    // implementacji metody Commpress. Mogą różnić się w mięsku. Nie ma to znaczenia
    void Compress();
}
