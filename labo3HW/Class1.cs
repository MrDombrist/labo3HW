using lab3_;
//Vector a = new Vector();
//a.Input();
//Console.WriteLine("Вектор только из неотрицательных элементов: " + a.plus());
//Console.WriteLine("Наибольший элемент вектора: " + a.Max());
//Console.WriteLine("модуль вектора: " + a.Module());
//Console.WriteLine(a.EL());
//a.Change();
//a.Output();
//Console.WriteLine();
Vector b = new Vector();
b.Ran();
b.Output();
Console.WriteLine();
b.Liner();
if (b.Prove()) { Console.WriteLine("Массив в порядке возрастания"); }
else { Console.WriteLine("Массив не в порядке возрастания "); }
b.Binary();
Vector c = new Vector(b);
b.Rotate();
b.Output();
Console.WriteLine();
if (b.EQual()) { Console.WriteLine("Есть соседние равные элементы"); }
else { Console.WriteLine("Нет соседних равных элементов"); }
c.Quick_Sort(0, (c.A.Length) - 1);
for (int i = 0; i < c.A.Length; i++)
{
    Console.Write(c.A[i] + " ");
}