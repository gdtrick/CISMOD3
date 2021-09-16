namespace MOD3
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting point
            double firstSum = addNumbers(2.50,3.47);
            Console.WriteLine(firstSum);
        }

        public static double addNumbers(double firstNumber, double secondNumber) => firstNumber + secondNumber;

        public static double addNumbers(double firstNumber, double secondNumber)
        {
            double returnNumber = firstNumber + secondNumber;
            return returnNumber;

            //return firstNumber + secondNumber;
        }
    }
}
