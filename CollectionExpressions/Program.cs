int[] x1 = new int[] { 1, 2, 3, 4 };
//lub
int[] x2 = { 1, 2, 3, 4 };
// w .net8.0 można wykorzystać ujednoliconą inicjalizacje w kolekcjach
int[] x3 = [ 1, 2, 3, 4];
//pusta tablica
int[] x4 = Array.Empty<int>();
// .net8.0
int [] x5 = [];
//tworzenie tablicy bajtów po staremu
WriteByteArray(new[] {(byte) 1, (byte) 2, (byte) 3});
//po nowemu
WriteByteArray([ 1, 2, 3]);
//Listy podobnie
List<int> x6 = new List<int> {1, 2, 3, 4};
//po nowemu
List<int> x7 = new List<int> [ 1, 2, 3, 4 ];
// dla obiektów typu Span też można
Span<DateTime> dates = stackalloc DateTime[] { GetDate(0), GetDatee(1) };
// uproszczenie
Span<DateTime> dates2 = [ GetDate(0), GetDatee(1) ];
WriteByteSpan(stackalloc[] { (byte) 1, (byte) 2, (byte) 3 });
WriteByteSpan([ 1, 2, 3 ]);
//łączenie kilku tablic w jedną tablicę 
// poprzednio
int[] numbers1 = [1, 2, 3];
int[] numbers2 = [4, 5, 6];
// int[] moreNumbers = numbers1.Concat(numbers2).Concat([7, 8, 9]).ToArray();
//nowa składnia - można wykorzystać spread operator
// int[] moreNumbers = [..numbers1, ..numbers2, 7, 8, 9];
// nie ma też problemu żeby zamienić to na typ List
List<int> moreNumbers = [..numbers1, ..numbers2, 7, 8, 9];