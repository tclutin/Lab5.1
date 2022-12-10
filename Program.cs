namespace Lab5._1
{
    class Program
    {
        private static string save;
        static void Main(string[] args)
        {
            Console.WriteLine("Example for double: 1,1, 2,2");
            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "q") break;

                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine((char)result);
                }
                else
                {
                    if (Convert.ToDouble(input) == Convert.ToDouble(save))
                    {
                        break;
                    }
                }
                save = input;
            }
        }
    }
}