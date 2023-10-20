namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Cube the product of two numbers\n" +
                "Enter the first number: ");

            firstNumber = inputNumber();

            Console.WriteLine("Enter the second number: ");
            secondNumber = inputNumber();

            double result = Math.Pow(firstNumber * secondNumber, 3);

            Console.WriteLine("Your result: " + result);



            int questionNumbers;

            for (int i = 1; i <= 5; i++) {
                questionNumbers = (i * 21) % 24 + 1;
                Console.WriteLine("Question number: " + questionNumbers);
            }
        }

        public static int inputNumber()
        {
            String input = "";
            int number = 0;
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    number = int.Parse(input);
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}