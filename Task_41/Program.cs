#pragma warning disable
Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите количество элементов массива:\t");

int elementsCount;
int.TryParse(Console.ReadLine()!, out elementsCount);
int[] Array = new int[elementsCount];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:\t");
    Array[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");
