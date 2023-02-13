// /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// // // [345, 897, 568, 234] -> 2
// // // */

Console.WriteLine("Задача №34");

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}


Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 Console.WriteLine();
// // /*
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
// // */3

Console.WriteLine("Задача №36");
Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[Size];


FillArrayRandomNumber(Numbers);
PrintArr(Numbers);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < Numbers.Length; i += 2)
{
    sumNumbersEvenIndex += Numbers[i];
}
Console.Write(sumNumbersEvenIndex);



void FillArrayRandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine("Задача №38 ");

Console.WriteLine("Введите размер массива  ");
int ssize = Convert.ToInt32(Console.ReadLine());
double[] nnumbers = new double[ssize];

FillArrayRandom(nnumbers);
Console.WriteLine("массив: ");
PrintA(nnumbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < nnumbers.Length; z++)
{
    if (nnumbers[z] > max)
        {
            max = nnumbers[z];
        }
    if (nnumbers[z] < min)
        {
            min = nnumbers[z];
        }
}

Console.WriteLine($"всего {nnumbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandom(double[] nnumbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            nnumbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintA(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}