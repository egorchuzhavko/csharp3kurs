//using System;
//using System.Text;

//namespace upstroki
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int p;
//            do
//            {
//                Console.Write("Введите номер задания: ");
//                p = Convert.ToInt32(Console.ReadLine());
//                switch (p)
//                {
//                    case 1:
//                        Console.Write("Введите последовательность символов: ");
//                        string str = Console.ReadLine();
//                        bool isPovt = false;
//                        for(int i = 0; i < str.Length; i++)
//                        {
//                            for(int j = i + 1; j<str.Length;j++)
//                            {
//                                if (str[i] == str[j])
//                                {
//                                    Console.WriteLine("В строке есть повторяющийся элемент");
//                                    isPovt = true;
//                                    break;
//                                }
//                            }
//                            if (isPovt)
//                                break;
//                        }
//                        if(!isPovt)
//                            Console.WriteLine("В строке нет повторяющихся элементов");
//                        break;
//                    case 2:
//                        Console.Write("Введите y: ");
//                        string y = Console.ReadLine();
//                        Console.Write("Введите x: ");
//                        string x = Console.ReadLine();
//                        int isEst = x.IndexOf(y);
//                        if (isEst >= 0)
//                            Console.WriteLine($"{y} является частью {x}");
//                        else if (isEst < 0)
//                            Console.WriteLine($"{y} не является частью {x}");
//                        break;
//                    case 3:
//                        Console.Write("Введите текст: ");
//                        string str3 = Console.ReadLine();
//                        str3 = str3.Replace("при", "   ");
//                        Console.WriteLine(str3);
//                        break;
//                    case 4:
//                        string text;
//                        Console.WriteLine("Введите текст, не забудьте поставить ! в конце");
//                        text = Console.ReadLine();
//                        Console.WriteLine("Введите чило d");
//                        int d = Convert.ToInt32(Console.ReadLine());
//                        string[] massiv;
//                        string result = null;
//                        int x1 = 0, kolvo = 0;
//                        int min = int.MaxValue;
//                        massiv = text.Substring(0, text.Length - 1).Split(' ');
//                        Console.WriteLine("Слова у которых длина меньше d");
//                        for (int i = 0; i < massiv.Length; i++)
//                        {
//                            if (massiv[i].Length < d)
//                                Console.WriteLine(massiv[i]);
//                        }
//                        for (int i = 0; i < massiv.Length; i++)
//                        {
//                            x1 = massiv[i].Length;
//                            if (x1 < min)
//                                min = x1;
//                        }
//                        for (int i = 0; i < massiv.Length; i++)
//                        {
//                            if (massiv[i].Length == min)
//                                kolvo++;
//                            else
//                                result += massiv[i] + " ";
//                        }
//                        Console.WriteLine($"Процент слов в тексте имеющих самую короткую длину: {(kolvo * 100 / (double)massiv.Length),5:f1} %");
//                        Console.WriteLine(result + "!");
//                        break;
//                    case 5:
//                        Console.WriteLine("Введите длинное натуральное число: ");
//                        string s5 = Console.ReadLine();
//                        char[] a5 = s5.ToCharArray();
//                        int sum = 0;
//                        for (int i = 0; i < a5.Length; i++)
//                            sum++;
//                        Console.WriteLine($"Количество чисел: {sum}");
//                        int yy = a5[a5.Length - (((a5.Length - 1) / 2) + 1)] - 48;
//                        string s55 = "";
//                        if (yy == 0)
//                        {
//                            for (int i = 0; i < a5.Length; i++)
//                            {
//                                if (i != a5.Length - (((a5.Length - 1) / 2) + 1))
//                                    s55 += a5[i];
//                            }
//                        }
//                        else
//                            Console.WriteLine("Среднее число не равно нулю");
//                        Console.WriteLine(s55);
//                        break;

//                    case 6:
//                        string table = "Чужавко*8*9*8*7*9*Спарф*10*9*10*10*10*Янушевич*10*5*9*9*8";
//                        string[] tempmas = table.Split("*");
//                        for (int i = 0; i < tempmas.Length; i++)
//                        {
//                            Console.Write(tempmas[i] + " ");
//                        }
//                        int count = 0, nn = 0;
//                        for(int i = 0; i < tempmas.Length; i++)
//                        {
//                            char[] temp = tempmas[i].ToCharArray();
//                            if (char.IsLetter(temp[0]))
//                            {
//                                count++;
//                            }
//                        }
//                        Console.WriteLine("\n\nКоличество учеников = " + count + "\n");
//                        string[,] resulttable = new string[count, 6];
//                        for(int i = 0; i < count; i++)
//                        {
//                            for(int j = 0; j < 6; j++, nn++)
//                            {
//                                resulttable[i, j] = tempmas[nn];
//                                Console.Write($"{resulttable[i, j],5:f1}");
//                            }
//                            Console.WriteLine();
//                        }
//                        Console.WriteLine();
//                        for(int i = 0; i < count; i++)
//                        {
//                            double summaocenok = 0;
//                            for(int j = 1; j < 6; j++)
//                            {
//                                summaocenok += Convert.ToDouble(resulttable[i, j]);
//                            }
//                            Console.WriteLine($"У {resulttable[i, 0]} средний балл равняется {(summaocenok / 5.0),2:f1}");
//                        }
//                        break;
//                }
//            } while (p != 0);
//        }
//    }
//}