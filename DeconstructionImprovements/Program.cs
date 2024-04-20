var point = new Point(2, 3);

// c#9
//initialization
(int x, int y) = point;

//assignment:
int x1 = 0;
int y1 = 0;
(x1, y1) = point;

//c#10
int a = 0;
(a, int b) = point;

internal record Point(int x, int y);
