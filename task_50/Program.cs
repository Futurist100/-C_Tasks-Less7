// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int[,] myArr = {
      {1,4,7,2},
      {5,9,2,3},
      {8,4,2,4},
};



void PrintPosition(int[,] myArr)
{ 
  int count = 0;

     for (int i = 0; i < myArr.GetLength(0); i++)

        {

          for (int j = 0; j < myArr.GetLength(1); j++)

           {

            if (myArr[i, j]==number) 
            {
            System.Console.WriteLine($"Позиция числа:{number}:  [{i} . {j}]");

            count++;

            System.Console.WriteLine(count);
            }

           }

        }
          if (count == 0) System.Console.WriteLine($"Числа:{number} в массиве нет");

}

PrintPosition(myArr);





