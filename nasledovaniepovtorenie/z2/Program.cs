//using z2;

//int id = 0;
//FixedWorker fw1 = new FixedWorker("Олежа", id++, 1000);
//FixedWorker fw2 = new FixedWorker("Олег", id++, 1000);
//TimeWorker tw1 = new TimeWorker("Антон", id++, 6);
//TimeWorker tw2 = new TimeWorker("Андрей", id++, 8);
//FixedWorker fw3 = new FixedWorker("Вадим", id++, 950);
//TimeWorker tw3 = new TimeWorker("Владислав", id++, 7);

//List<Worker> workers = new List<Worker>();
//workers.Add(fw1);
//workers.Add(fw2);
//workers.Add(tw1);
//workers.Add(tw2);
//workers.Add(tw3);
//workers.Add(fw3);

//foreach (var worker in workers)
//{
//    worker.CalcSalary();
//    Console.WriteLine(worker);
//}

//Console.WriteLine(new string('-', 50) + "\n");

//workers.Sort();

//foreach (var worker in workers)
//{
//    Console.WriteLine(worker);
//}

//Console.WriteLine(new string('-', 50) + "\n");

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(workers[i]);
//}

//Console.WriteLine(new string('-', 50) + "\n");

//for (int i = workers.Count - 1; i >= workers.Count - 3; i--)
//{
//    Console.WriteLine(workers[i].name + ", его идентификатор = " + workers[i].id);
//}





class Test
{
    delegate int F();
    static void Main()
    {
        List<F> fs = new List<F>();
        int[] xs = { 1, 2, 3 };
        int i = 0;
        for ( i = 0; i < 3; i++)
        {
            fs.Add(() => xs[i++]);
        }
         i = 0;
        foreach (F f in fs)
        {
            Console.WriteLine(f());
        }
        Console.ReadLine();
    }
}


















////18.System.IndexOutOfRangeException: "Индекс находился вне границ массива."
////19.B.Method1
////Error: “Ссылка на объект не указывает на экземпляр объекта”
////20.	Error: Для нестатического поля, метода или свойства «Program.i» требуется ссылка на объект.
////21.	Нет 
////22.	M1, M3 – абстрактные классы(могут быть, так как могут быть интерфейсами); M2, M4 - интерфейсы
////23.x.Count = 1;
////Невозможно присвоить “Count” значение, так как он является «группа методов».
////24.	Base
////25.	Ошибки с доступом к полям a и b
////26.	Да, но он ничего не выведет
////27.	-
