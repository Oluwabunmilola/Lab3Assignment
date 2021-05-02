
using System;
 class Student
        {
            double cgpa = 0, percentage = 0;
            public void cgpaCalculation()
            {   
            double sum = 0;
            int [] marks = new int[5];
            for(int x = 0; x <5; x++)
            {
                 marks [x] = Convert.ToInt32(Console.ReadLine());
            }
            for(int y = 0; y < 5; y++)
            {
                sum = sum + marks[y];
                cgpa =sum / 5;
            }
            Console.WriteLine("Hello there!! Your CGPA is {0}",cgpa);
            }
            public void cgpaPercentage()
            {
                percentage = cgpa * 9.5;
                Console.WriteLine("hello there!!  Your percentage CGPA is {0}", percentage);
        }
        }