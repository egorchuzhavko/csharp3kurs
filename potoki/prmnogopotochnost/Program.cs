// See https://aka.ms/new-console-template for more information
Thread sl = new Thread(Slojenie);
Thread umn = new Thread(Umnojenie);
Thread st = new Thread(Stepen);

sl.Start();
umn.Start();
st.Start();


static void Slojenie()
{
    int chislo = 2;
    for(int i = 2; i <= 10; i++)
    {
        chislo +=chislo;
    }
    Console.WriteLine("Сложение - " + chislo);
}

static void Umnojenie()
{
    int chislo = 2;
    for (int i = 2; i <= 10; i++)
    {
        chislo *= 2;
    }
    Console.WriteLine("Умножение - " + chislo);
}

static void Stepen()
{
    Console.WriteLine("Степень - " + Math.Pow(2, 10));
}