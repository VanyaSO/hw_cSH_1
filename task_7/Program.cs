// Користувач вводить речення з клавіатури. 
// Вам необхідно перевернути кожне слово речення і вивести результат на екрані.
// Наприклад:
// користувач ввів: sun cat dogs cup tea;
// після перевороту: nus tac sgod puc aet.

namespace task_7
{
    internal class Program
    {
        
        static string ReverseString(string str)
        {
            char[] newStr = new char[str.Length];
            int newCharI = 0;
            int indexStartWord = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    newStr[newCharI++] = ' ';
                }
                
                // Находим начало слова
                if (str[i] != ' ' && (i == 0 || str[i - 1] == ' '))
                {
                    indexStartWord = i;
                }

                // Находим конец слова
                if (str[i] != ' ' && (i == str.Length - 1 || str[i + 1] == ' '))
                {
                    int indexEndWord = i;

                    // Переворачиваем его
                    for (int j = indexEndWord; j >= indexStartWord; j--)
                    {
                        newStr[newCharI++] = str[j];
                    }
                }
            }

            return new string(newStr);
        }

        static void Main()
        {
            Console.WriteLine("Hi, enter random words");
            
            string userString = Console.ReadLine();
            Console.WriteLine(ReverseString(userString));
        }
    }
}