namespace FindAvg
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Xiao Li / Kanchan Khadka " +
                "\nCPS 3330*01 - SOFTWARE DEV WITH FRAMEWORKS");
            Console.WriteLine("Instructor: Dr. Yulia Kumar");
            Console.WriteLine("Version: {0}", Environment.Version.ToString());

            double a,b,c, avg;

            Console.Write("\nEnter a interger number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a another interger number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a another interger number: ");
            c = Convert.ToDouble(Console.ReadLine());

            avg = TestAvg.Average.MyAvg1(a,b);
            avg = TestAvg.Average.MyAvg1(a,b,c);
        }

    }
}

