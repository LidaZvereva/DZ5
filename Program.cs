// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int [] EnterRandomArray()
// {  
//     Console.WriteLine("Введите размер массива");
//     int arraySize=Convert.ToInt32(Console.ReadLine());
//     int []array= new int [arraySize];
    
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i]=new Random().Next(100,999);
//     }
//     System.Console.WriteLine("Массив");
//     System.Console.WriteLine(String.Join(",",array));
//     return array;
//     }
 
// void SumOfEvenNumbers(int [] array)
// {
//     int count=0;
//     for (int j=0; j<array.Length; j++)
//     {
//         if (array[j]%2==0)
//         {
//         count++;
//         }
//     }
    
//     System.Console.WriteLine($"Количество чётных чисел в массиве {count}");
// } 

//  SumOfEvenNumbers(EnterRandomArray());
