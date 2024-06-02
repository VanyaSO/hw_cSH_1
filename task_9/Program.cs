// Створіть додаток для підрахунку кількості входжень
// підрядка в рядок. Користувач вводить вихідний рядок і
// слово для пошуку. Додаток відображає результат пошуку.
// Наприклад:
// користувач ввів: Why she had to go. I don't know, she wouldn't say;
// підрядок для пошуку: she;
// результат пошуку: 2.
    
namespace task_9
{
    internal class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Enter text");
            string userText = Console.ReadLine();
            string[] arrayWord = userText.Split();

            Console.WriteLine("Enter desired substring");
            string desiredSubstring = Console.ReadLine();
            int countFoundSubstring = 0;

            for (int i = 0; i < arrayWord.Length; i++)
            {
                if (arrayWord[i] == desiredSubstring)
                {
                    countFoundSubstring += 1;
                }
            }

            Console.WriteLine($"Found substring: {countFoundSubstring}");
        }
    }
}