using System;

namespace Program
{
    class program
    {
        static int Index(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {
                if ((array[i] % 2) == 1)
                    return i;
            }

            return -1;
        }

        static void Main()
        {
            int [] data = {2, -6, -2, 5, -4, -1, 24, -7};
            int arithmetic = 0;
            int summanegative = 1;
            int summa = 0;

            //додає всі елементи масиву в змінну summa.
            for (int a = 0; a < data.Length; a++) 
            {
                summa += data[a];

                if (a == 7) {
                    summa /= 2; //получаєм середне арифметичне від всього масиву
                    for (int y = 0; y < data.Length; y++) {
                        if (data[y] < summa) 
                            arithmetic++; //шукає кількість елементів, менших від середнього арифметичного елементів масиву.
                    }
                } 
            }

            for (int i = 0; i < data.Length; i++) //перебирає всі елементи масиву і показує на екран за допомогою CW.
            {
                Console.WriteLine("El: " + data[i]);
                if (data[i] <= 0)
                    summanegative *= data[i]; //множить від'ємні елементи масиву.

                if (i == 7) {
                    Console.WriteLine("добуток вiд'ємних елементiв масиву: " + summanegative);
                    Console.WriteLine("середнє арифметичне: " + summa);
                    Console.WriteLine("кiлькiсть елементiв, менших вiд середнiх арефметичних елементiв масиву: " + arithmetic);
                }
            }
            int result = Index(data);
            Console.WriteLine("номер найбільшого із елементів масиву із непарним номером: " + result);
        }
    }
}