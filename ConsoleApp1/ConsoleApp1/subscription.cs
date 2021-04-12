using System;

namespace ConsoleApp1
{
    class subscription
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;


            if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
                Console.WriteLine($"Renew now and save{discountPercentage}%!");
            }
            else if (daysUntilExpiration > 0 && daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires within in {daysUntilExpiration} day!");
                discountPercentage = 10;
                Console.WriteLine($"Renew now and save{discountPercentage}%!");

            }
            else if (daysUntilExpiration > 0 && daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");


            }
            else
            {

                Console.WriteLine("Your subscription has expired.");
            }
        }
    }
}
