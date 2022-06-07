using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Mas <T>
    {
        private int size;
        private T[] el;

        public Mas(int size)
        {
            this.size = size;
            el = new T[size];
        }

        public T this[int index] { get { return el[index]; } set { el[index] = value; } }

        public void FillEl()
        {
            Random rnd = new Random();
            for (int i = 0; i < el.Length; i++)
            {
                el[i] =(T) (dynamic)rnd.Next(48, 60);
            }
        }

        public static bool operator ==(Mas<T> first, Mas<T> second)
        {
            if (first.size != second.size)
                return false;
            else
                for (int i = 0; i < first.size; i++)
                    if (first.el[i] != (dynamic)second.el[i])
                        return false;
            return true;
        }

        public static bool operator !=(Mas<T> first, Mas<T> second)
        {
            if (first.size != second.size)
                return true;
            else
                for (int i = 0; i < first.size; i++)
                    if (first.el[i] == (dynamic)second.el[i])
                        return true;
            return false;
        }

        public static Mas<T> operator ++(Mas<T> obj)
        {
            for (int i = 0; i < obj.size; i++)
                obj.el[i] += (dynamic)1;
            return obj;
        }

        public static Mas<T> operator --(Mas<T> obj)
        {
            for (int i = 0; i < obj.size; i++)
                obj.el[i] -= (dynamic)1;
            return obj;
        }

        public override string ToString()
        {
            string temp = "";
            foreach (T item in el)
            {
                temp += Convert.ToString(item) + " ";
            }
            return temp;
        }
    }
}
