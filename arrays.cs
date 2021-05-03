
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Assignment
{
 class Student
        {
            double cgpa = 0, percentage = 0;
            List<double> ScoresInBase10= new List<double>();
  public void cgpaCalculation()
            {   
            double sum = 0;
            int [] marks = new int[5]; 

              Console.WriteLine("Welcome!! Here's to help you calculate your scores!");
            for(int x = 0; x <5; x++)
            {

                 marks [x] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(double score in marks)
            {
           double Answer=score/10; //Getting the base 10 of the scores
           ScoresInBase10.Add(Answer);//add adds anything to a list
            }
        sum=ScoresInBase10.Sum();
             cgpa =sum / 5;
            Console.WriteLine("Hello there!! Your CGPA is {0}",cgpa);
            }
            public void cgpaPercentage()
            {
                percentage = cgpa * 9.5;
                Console.WriteLine($"hello there!!  Your percentage CGPA is {percentage:F2}"); //F2 rounds off to two decimal plaace.
        }
        }
}