namespace TestAvg
{
    public class Average
    {
        public static double MyAvg1(double num1, double num2)
        {
            double avg;
            avg = (num1 + num2) / 2;

            Console.WriteLine("\nThe avgerage of " + num1 + " and " + num2 + " will return " + avg);
            return avg;
        }

        public static double MyAvg1(double num1, double num2, double num3)
        {
            double avg;
            avg = (num1 + num2 + num3) / 3;

            Console.WriteLine("The avgerage of " + num1 + ", " + num2 + " and " + num3 + " will return " + avg);
            return avg;
        }
    }
}