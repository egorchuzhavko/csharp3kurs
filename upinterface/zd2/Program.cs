using zd2;

Dot dot = new Dot(1, 1);
Console.WriteLine(dot.Square());
Circle circle = new Circle(dot, 1.5, 2);
Console.WriteLine("Радиус = " + circle.Square());
Dot circle1 = new Circle(dot, 1.5, 2);
Console.WriteLine("Радиус = " + (circle1 as Circle).Square());
iFigure[] a = new iFigure[3];
a[0] = dot;
a[1] = circle;
a[2] = circle1;
Console.WriteLine(  "----------------");
foreach (var item in a)
{
    Console.WriteLine (item.Square());

}