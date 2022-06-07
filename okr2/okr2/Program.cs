using okr2;

Camera cam1 = new Camera("Модель 1", 4, "пластик");
DigitalCamera cam2 = new DigitalCamera("Модель 2", 8, "металл", 3);
Console.WriteLine(cam1);

if (cam1.Expensive())
    Console.WriteLine("Камера - " + cam1.Model + " дорогая");
else
    Console.WriteLine("Камера - " + cam1.Model + " не дорогая");
Console.WriteLine("\n\n" + cam2);

if (cam2.Expensive())
    Console.WriteLine("Камера - " + cam2.Model + " дорогая");
else
    Console.WriteLine("Камера - " + cam2.Model + " не дорогая");

cam2.UpdateModel();
Console.WriteLine("\n\n" + cam2);

if (cam2.Expensive())
    Console.WriteLine("Камера - " + cam2.Model + " дорогая");
else
    Console.WriteLine("Камера - " + cam2.Model + " не дорогая");