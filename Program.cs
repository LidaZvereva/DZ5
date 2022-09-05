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

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] EnterRandomArray()
// {  
//     Console.WriteLine("Введите размер массива");
//     int arraySize=Convert.ToInt32(Console.ReadLine());
//     int []array= new int [arraySize];
    
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i]=new Random().Next(0,15);
//     }
//     System.Console.WriteLine("Массив:");
//     System.Console.WriteLine(String.Join(",",array));
//     return array;
//     }
 
// void SumOfNotEvenPositions(int [] array)
// {
//     int count=0;
//     for (int j=0; j<array.Length; j++)
//     {
//         if (j%2!=0)
//         {
//         count+=array[j];
//         }
//     }
//     System.Console.WriteLine($"Сумма нечетных позиций: {count}");
// } 
//  SumOfNotEvenPositions(EnterRandomArray());

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int [] EnterRandomArray()
{  
    Console.WriteLine("Введите размер массива");
    int arraySize=Convert.ToInt32(Console.ReadLine());
    int []array= new int [arraySize];
    
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-100,100);
       
    }
    System.Console.WriteLine(String.Join(",",array));
    return array;

}

void PeriodOfPairs(int [] array)
{
    int Pair=0;
    
    int array2Size=(array.Length)/2;
    int []array2=new int [array2Size];
    int j=0;
    
    for (int y=0;y<array2.Length;y++)
    {
            Pair=array[j]*array[array.Length-1-j];
            array2[y]=Pair;
            j++;
    }
    Console.WriteLine("Новый массив ");
    Console.WriteLine(String.Join(",",array2));
    
}
 PeriodOfPairs(EnterRandomArray());

