// aliases - dobre zastosowanie dla tupli oraz typów generycznych

// użycie aliasów do długich deklaracji, trzeba pamiętać że można je w razie czego
// zadeklarować globalnie
//przy deklarowaniu aliasów typów które nie są typami prostymi musimy podać pełną 
//nazwę namespace
using CountryCities = System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>;

using Point = (int x, int y);
var point = new Point( 1, 34 );
//destrukturyzacja
(var xPos, var yPos) = point;

string GetQuadrant(Point point) => point switch
{
    var (x, y) when x > 0 && y > 0 => "I",
    var (x, y) when x < 0 && y > 0 => "II",
    var (x, y) when x < 0 && y < 0 => "III",
    var (x, y) when x > 0 && y < 0 => "IV",
    var (_, _) => "On the axis"
};

class Assets 
{
    public CountryCities CountryCities { get; set; } = []; //teraz tak można definiować nową kolekcję
}