using System;

namespace StudentGradeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] student1 = { 85, 90, 78 };
        int[] student2 = { 88, 73, 80 };
        int[] student3 = { 90, 85, 88 };
        int[] student4 = { 92, 90, 95 };
        int[] student5 = { 85, 80, 85 };  
        
        Console.WriteLine("Student 1 Grades: " + student1[0] + ", " + student1[1] + ", " + student1[2]);
        Console.WriteLine("Student 2 Grades: " + student2[0] + ", " + student2[1] + ", " + student2[2]); 
        Console.WriteLine("Student 3 Grades: " + student3[0] + ", " + student3[1] + ", " + student3[2]); 
        Console.WriteLine("Student 4 Grades: " + student4[0] + ", " + student4[1] + ", " + student4[2]); 
        Console.WriteLine("Student 3 Grades: " + student5[0] + ", " + student5[1] + ", " + student5[2]); 
        Console.WriteLine("----------------------------------------------------------------------------");
        
        double avg1 = student1.Average();
        double avg2 = student2.Average();
        double avg3 = student3.Average();
        double avg4 = student4.Average();
        double avg5 = student5.Average();

        Console.WriteLine("Student 1 Average: " + avg1);
        Console.WriteLine("Student 2 Average: " + avg2);
        Console.WriteLine("Student 3 Average: " + avg3);
        Console.WriteLine("Student 4 Average: " + avg4);
        Console.WriteLine("Student 5 Average: " + avg5);
        Console.WriteLine("----------------------------------------------------------------------------");


        double highestAverage = new double[] { avg1, avg2, avg3, avg4, avg5 }.Max();
        Console.WriteLine("Highest Average Grade: " + highestAverage);
        Console.WriteLine("----------------------------------------------------------------------------");
        
        Console.ReadKey();
        }
    }
} 
