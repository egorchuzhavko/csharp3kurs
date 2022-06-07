using System.Linq;
//using z1;

//try
//{
//    MStack<string> stack = new MStack<string>(5);
//    stack.Push("Антон");
//    stack.Push("Дима");
//    stack.Push("Вася");
//    stack.Push("Гена");
//    stack.Push("Вадим");

//    var head = stack.Pop();
//    Console.WriteLine(head);

//    head = stack.Peek();
//    Console.WriteLine(head);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

List<int> list = new List<int>() { -4, 6, 1, 2, 7, 8 };
Console.WriteLine("Должно вывести:\n-4, 1, 7, ");
var newlist = list.Where(x => x <= 0 | (x % 2 != 0 & x > 0));
foreach (var item in newlist)
{
    Console.Write(item+", ");
}