using System;

namespace FirstProject;
public class Utils
{
    //example of generic method
    public static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    } 
}
