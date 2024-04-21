using System.Numerics;

int[] ints = new int[] { 1, 2, 3, 4 };
var sum = AddAll(ints);
var decimals = new decimal[] { 2.2m, 3.4m};
var sum2 = AddAll(decimals);

Console.WriteLine(sum);
Console.WriteLine(sum2);

T AddAll<T>(T[] values) where T : INumber<T>
{
    T result = T.Zero;
    foreach (var value in values)
    {
        result += value;
    }
    return result;
}
