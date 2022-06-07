Console.WriteLine("Введите кол-во степеней числа 3: ");
double s = Convert.ToDouble(Console.ReadLine());
using (BinaryWriter sw = new BinaryWriter(File.Open("test.bin", FileMode.Create)))
{
    for (double i = 1; i < s + 1; i++)
    {
        sw.Write(Math.Pow(3, i));
    }
}
Console.WriteLine();
using (BinaryReader sr = new BinaryReader(File.Open("test.bin",FileMode.Open)))
{
    bool flag = false;
    while (sr.BaseStream.Position!=sr.BaseStream.Length)
    {
        var qwerty = sr.ReadDouble();
        if (flag)
            Console.WriteLine(qwerty);
        flag = !flag;
    }
}