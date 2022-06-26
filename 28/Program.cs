int [] mass = new int [8];
void metod (int [] mass1)
{
    for (int i = 0; i < mass1.Length; i++)
    {
    Console.Write("Введите элемент массива =  ");
    mass1[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Ваш массив [");
    for (int i = 0; i < mass1.Length - 1; i++)
    {
    Console.Write($"{mass1[i]}, ");
    }
    Console.Write($"{mass1[mass1.Length - 1]}");
    Console.WriteLine("]");
}
metod(mass);

