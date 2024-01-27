using System;

namespace FirstProject;
public class Currency
{
    public string Name { get; set; }
    public string FullName { get; set; }
    public double Rate { get; set; }
    public Currency(string name, string fullName, double rate)
    {
        Name = name;
        FullName = fullName;
        Rate = rate;
    }
}
