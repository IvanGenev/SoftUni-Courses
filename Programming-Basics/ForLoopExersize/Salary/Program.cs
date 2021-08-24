﻿using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int facebook = 150;
            const int instagram = 100;
            const int reddit = 50;

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string openedWebsites = Console.ReadLine();
                if (openedWebsites == "Facebook")
                {
                    salary -= facebook;
                }
                else if (openedWebsites == "Instagram")
                {
                    salary -= instagram;
                }
                else if (openedWebsites == "Reddit")
                {
                    salary -= reddit;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
