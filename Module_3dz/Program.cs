/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           for (int i = 0; i < numbers.Length; i++)
           {
               Console.WriteLine(numbers[i]);
           }
       }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           int[] numbers = { 1, 2, 3, 4, 5 };
           int indexToDelete = 2; 

           if (indexToDelete >= 0 && indexToDelete < numbers.Length)
           {
               int[] newArray = new int[numbers.Length - 1];
               Array.Copy(numbers, 0, newArray, 0, indexToDelete);
               Array.Copy(numbers, indexToDelete + 1, newArray, indexToDelete, numbers.Length - indexToDelete - 1);

               numbers = newArray;

               Console.WriteLine("Массив после удаления элемента:");
               for (int i = 0; i < numbers.Length; i++)
               {
                   Console.WriteLine(numbers);
               }
           }
           else
           {
               Console.WriteLine("Неверный индекс для удаления элемента.");
           }
       }
   }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Введите символы с клавиатуры. Для завершения введите точку.");

           int Count = 0;

           while (true)
           {
               char inputChar = Console.ReadKey().KeyChar;

               if (inputChar == '.')
               {
                   break;
               }

               if (inputChar == ' ')
               {
                   Count++;
               }
           }

           Console.WriteLine("\nКоличество введенных пробелов: " + Count);
       }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           int[,] array = new int[5, 5];
           Random random = new Random();

           for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   array[i, j] = random.Next(-100, 101); 
               }
           }

           int minValue = array[0, 0];
           int maxValue = array[0, 0];
           int minI = 0, minJ = 0, maxI = 0, maxJ = 0;

           for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   if (array[i, j] < minValue)
                   {
                       minValue = array[i, j];
                       minI = i;
                       minJ = j;
                   }

                   if (array[i, j] > maxValue)
                   {
                       maxValue = array[i, j];
                       maxI = i;
                       maxJ = j;
                   }
               }
           }


           int startRow = Math.Min(minI, maxI);
           int endRow = Math.Max(minI, maxI);
           int startCol = Math.Min(minJ, maxJ);
           int endCol = Math.Max(minJ, maxJ);

           int sum = 0;
           for (int i = startRow; i <= endRow; i++)
           {
               for (int j = startCol; j <= endCol; j++)
               {
                   sum += array[i, j];
               }
           }

           Console.WriteLine("Двумерный массив:");
           for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   Console.Write(array[i, j] + "\t");
               }
               Console.WriteLine();
           }

           Console.WriteLine("Сумма элементов между минимальным и максимальным элементами: " + sum);
       }
   }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           string word = "класс";

           string result = ReplaceDuplicateCharacters(word, 'с', '1');

           Console.WriteLine("Исходное слово: " + word);
           Console.WriteLine("Результат замены: " + result);
       }

       static string ReplaceDuplicateCharacters(string input, char targetChar, char replacementChar)
       {
           char[] charArray = input.ToCharArray();

           bool foundFirst = false;

           for (int i = 0; i < charArray.Length; i++)
           {
               if (charArray[i] == targetChar)
               {
                   if (foundFirst)
                   {

                       charArray[i] = replacementChar;
                   }
                   else
                   {
                       foundFirst = true;
                   }
               }
           }

           return new string(charArray);
       }
   }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Введите строку цифр и пробелов:");
           string input = Console.ReadLine();

           string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           int sum = 0;

           for (int i = 0; i < words.Length; i++)
           {
               if (words[i].EndsWith("3") || words[i].EndsWith("4"))
               {
                   int number;
                   if (int.TryParse(words[i], out number))
                   {
                       sum += number;
                   }
               }
           }

           Console.WriteLine("Сумма чисел, оканчивающихся на 3 или 4: " + sum);
       }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
   internal class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Введите строку:");
           string inputString = Console.ReadLine();

           char targetChar = 'P';
           int count = 0;

           for (int i = 0; i < inputString.Length; i++)
           {
               if (inputString[i] == targetChar)
               {
                   count++;
               }
           }

           Console.WriteLine($"Количество букв '{targetChar}' в строке: {count}");
       }
   }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            bool found = false;
            int textLength = text.Length;

            for (int i = 0; i < textLength - 2; i++)
            {
                if (text[i] == 'o' && text[i + 1] == 'n' && text[i + 2] == 'e')
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Слово 'one' найдено в тексте.");
            }
            else
            {
                Console.WriteLine("Слово 'one' не найдено в тексте.");
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();

            int digitCount = 0;
            int stringLength = inputString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                if (char.IsDigit(inputString[i]))
                {
                    digitCount++;
                }
            }

            Console.WriteLine("Количество цифр в строке: " + digitCount);
            Console.ReadKey();
        }
    }
}