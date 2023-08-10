// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int[4];
// int count=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     Console.Write(array[i]+" ");
    
//     if(array[i]%2==0)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Количество четных элементов = {count++}");


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = new int[4];
// int sumNPos=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(0,10);
//     Console.Write(array[i]+" ");

//     if(i%2==0)
//     {
//         sumNPos+=array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine(sumNPos);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    Random x= new Random();
    double r= Convert.ToDouble(x.Next(0,100)/100.00);
    array[i]=new Random().Next(0,100)*r;
    Console.Write(array[i]+" ");
}
double maxNum=array[0];
double minNum=array[0];
double A=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>maxNum)
        {
            maxNum=array[i];
        }
    else if(array[i]<minNum)
    {
        minNum=array[i];
    }
A=maxNum-minNum;
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива = {maxNum}");
Console.WriteLine($"Минимальный элемент массива = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {A}");