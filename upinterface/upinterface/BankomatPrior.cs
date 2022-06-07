using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upinterface
{
    internal class BankomatPrior : iBankomat, iBankomatPriorbank
    {
        public void Adress(string adress)
        {
            Console.WriteLine("Адрес = " + adress);
        }
        public void TakeMoney()
        {
            Console.WriteLine("Снял деньги с банкомата");
        }
        public void TakeBonus()
        {
            Console.WriteLine("Получил бонус");
        }
    }
}
