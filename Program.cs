using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha34()
            {//Задайте массив заполненный случайными положительными трёхзначными числами. 
            //Напишите программу, которая покажет количество чётных чисел в массиве.
             int[] array=new int[8] ; 
             FillArray(array,100,999);
             PrintArray(array);

             int count=0;
             for(int i=0;i<array.Length;i++)
             {
                if(array[i]%2==0) count++;
             }
             Console.WriteLine("Количество четных чисел в массиве "+count);
            }
            void FillArray(int[] array,int StartNumber=0,int FinishNumber=1)
            {
                FinishNumber++;
                Random random=new Random();
                for (int i=0;i<array.Length;i++)
                {
                    array[i]=random.Next(StartNumber,FinishNumber);
                }
            }
            void PrintArray(int[] array)
            {
                Console.WriteLine("массив");
                for(int i=0;i<array.Length;i++)
                {
                    Console.WriteLine(array[i]+"\t");
                }
                Console.WriteLine();
            }
            Zadacha34();
        }
        
     }
    
}