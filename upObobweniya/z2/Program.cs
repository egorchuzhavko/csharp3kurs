using z2;

Mas<float> first = new Mas<float>(3);
Mas<float> second = new Mas<float>(4);
Mas<float> third = new Mas<float>(3);

first.FillEl();
second.FillEl();
third.FillEl();

Console.WriteLine("Первый: " + first);
Console.WriteLine("Второй: " + second);
Console.WriteLine("Третий: " + third);

Console.WriteLine("\nпервый==третий");
Console.WriteLine(first == third);
Console.WriteLine("первый!=второй");
Console.WriteLine(first != second);

Console.WriteLine("\n++первый");
Console.WriteLine(++first);
Console.WriteLine("--второй");
Console.WriteLine(--second);