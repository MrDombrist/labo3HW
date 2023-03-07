using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab3_
{
    class Vector
    {
        public Vector() { }
        public Vector(int n, double[] mas)
        {
            a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = mas[i];
            }
        }
        public Vector(Vector b)
        {
            int n = b.a.Length;
            a = new double[n];
            for (int i = 0; i < b.a.Length; i++)
            {
                a[i] = b.a[i];
            }
        }
        public override string ToString()
        {
            string name = " ";
            for (int i = 0; i < a.Length; i++)
            {
                name = name + a[i] + " ";
            }
            return name;
        }
        public void Input()
        {
            Console.WriteLine("какая размерности вектор?");
            int n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

        }
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public double Module()
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += Math.Pow(a[i], 2);
            }
            return Math.Sqrt(result);
        }
        public double Max()
        {
            double max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                max = Math.Max(max, a[i]);
            }
            return max;
        }
        public int Min()
        {
            double min = a[0]; int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    k = i;
                }
            }
            return k;
        }
        public Vector plus()
        {

            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) { j++; }
            }
            Vector b = new Vector();
            b.a = new double[j];
            for (int i = 0, k = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b.a[k] = a[i];
                    k++;
                }
            }
            return b;
        }
        public static Vector operator +(Vector left, Vector right)
        {
            if (left.a.Length != right.a.Length)
            {
                throw new InvalidOperationException("Размеры векторов не совпадают.");

            }
            Vector result = new Vector();
            result.a = new double[left.a.Length];
            for (int i = 0; i < result.a.Length; i++)
            {
                result.a[i] = left.a[i] + right.a[i];
            }
            return result;
        }
        public static double operator *(Vector left, Vector right)
        {
            if (left.a.Length != right.a.Length)
            {
                throw new InvalidOperationException("Размеры векторов не совпадают.");

            }
            double umn = 0;
            for (int i = 0; i < left.a.Length; i++)
            {
                umn += left.a[i] * right.a[i];
            }
            return umn;
        }
        public static bool operator !=(Vector left, Vector right)
        {
            if (left == right) { return false; }
            return true;
        }
        public static bool operator ==(Vector left, Vector right)
        {
            if (left.a.Length != right.a.Length)
            {
                return false;

            }
            int k = 0;
            for (int i = 0; i < left.a.Length; i++)
            {
                if (left.a[i] == right.a[i])
                {
                    k++;
                }
            }
            if (k == left.a.Length) { return true; }
            return false;
        }
        public double EL()
        {
            Console.Write("Введите индекс элемента, который вы ищете: ");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j < a.Length)
            {
                return a[j];
            }
            else { throw new InvalidOperationException("Вы вышли с диапозона массива"); }
        }
        public void Change()
        {
            Console.Write("Введите индекс элемента, который вы ищете: ");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j < a.Length)
            {
                Console.Write("на какой элемент вы хотите поменять: ");
                int n = Convert.ToInt32(Console.ReadLine());
                a[j] = n;
            }
            else { return; }
        }
        public void Ran()
        {
            Console.Write("Какое количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            Console.WriteLine("Введите диапозон(два значения) в котором будет заполнен массив: ");
            double c = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                if (b >= c)
                {
                    a[i] = c + random.NextDouble();
                }
                else { a[i] = b + random.NextDouble(); }

            }
        }
        public void Liner()
        {
            Console.WriteLine("Введите число для поиска: ");
            double p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < this.a.Length; i++)
            {
                if (a[i] == p) { Console.WriteLine("Элемент найден"); return; }
            }
            Console.WriteLine("Такого элемента нет");
        }
        public bool Prove()
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= a[i - 1]) { continue; }
                else if (a[i] < a[i - 1]) { return false; }
            }
            return true;
        }
        public void Binary()
        {
            Console.WriteLine("Введите элемент,который ищете: ");
            double n = Convert.ToDouble(Console.ReadLine());
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (n == a[mid])
                {
                    Console.WriteLine("Такой элемент есть. ");
                }
                else if (n < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
        }
        public Vector Rotate()
        {
            Vector vector = new Vector();
            vector.a = new double[a.Length];
            for (int i = 1; i < this.a.Length; i++)
            {
                vector.a[i - 1] = a[i];
            }
            vector.a[a.Length - 1] = 0;
            return vector;
        }
        public bool EQual()
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
        public void Quick_Sort(int left, int right)
        {
            if (left < right)
            {
                int Pivot = Partition(left, right);

                if (Pivot > 1)
                {
                    Quick_Sort(left, Pivot - 1);
                }
                if (Pivot + 1 < right)
                {
                    Quick_Sort(Pivot + 1, right);
                }
            }

        }

        public int Partition(int left, int right)
        {
            double Pivot = a[left];
            while (true)
            {

                while (a[left] < Pivot)
                {
                    left++;
                }

                while (a[right] > Pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (a[left] == a[right]) return right;

                    double temp = a[left];
                    a[left] = a[right];
                    a[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        public double[] A
        {
            get { return a; }
            set { a = value; }
        }
        private double[] a;
    }
}