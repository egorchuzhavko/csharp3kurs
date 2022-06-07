//////int[] array = new int[] { 3, -2, 3, -4, 9, 3, 8 };
//////Console.WriteLine("\n Минимальный по модулю элемент массива: " + array.Min(a => Math.Abs(a)));
//////Console.WriteLine(
//////    "\nСумма элементов массива, расположенных между первым и последним нулевыми элементами: " +
//////    array.SkipWhile(x => x != 0).Reverse().SkipWhile(x => x != 0).Sum());

//////var q = array.Where(x => x >= 0).Concat(array.Where(y => y < 0)).ToArray();
//////for (int i = 0; i < array.Length; i++)
//////{
//////    Console.Write(array[i] + " ");
//////}
//////Console.WriteLine();
//////for (int i = 0; i < q.Length; i++)
//////{
//////    Console.Write(q[i] + " ");
//////}

