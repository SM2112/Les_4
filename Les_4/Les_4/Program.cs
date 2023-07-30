namespace Les_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Напишите свой любимый цвет на английском  языке");
                var color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет - красный!");
                    break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет - зеленый!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет - бирюзовый!");
                        break;
                    
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ваш любимый цвет - желтый!");
                        break;
                }

            }

        }
    }
}