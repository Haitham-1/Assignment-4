using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

enum DayOfWeek
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
class Program
{
    static void Main()
    {    /*
          
        //Question 05 : Input Validation with Loops

        int attempts = 0;
        bool isValid = false;

        do
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpace = false;

            // Check minimum length
            bool hasMinLength = password.Length >= 8;

            // Check characters using foreach
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;

                if (char.IsDigit(c))
                    hasDigit = true;

                if (char.IsWhiteSpace(c))
                    hasSpace = true;
            }

            // Validate all conditions
            if (hasMinLength && hasUpper && hasDigit && !hasSpace)
            {
                Console.WriteLine("Password accepted!");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid password:");

                if (!hasMinLength)
                    Console.WriteLine("- Must be at least 8 characters");

                if (!hasUpper)
                    Console.WriteLine("- Must contain at least one uppercase letter");

                if (!hasDigit)
                    Console.WriteLine("- Must contain at least one digit");

                if (hasSpace)
                    Console.WriteLine("- Must not contain spaces");

                attempts++;
            }

        } while (!isValid && attempts < 5);

        if (!isValid)
        {
            Console.WriteLine("Account locked");
        }
        // ---------------------------------------------------------------------------------
        //Question 06 : Array Processing

        int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

        // (a) Display all failing scores (below 50)
        Console.WriteLine("Failing scores (below 50):");
        foreach(int x in scores)
        {  
            if(x < 50)
            Console.WriteLine(x); 
        }

        // (b) Find first score above 90 and stop searching
        Console.WriteLine("\nFirst score above 90:");

        foreach (int score in scores)
        {
            if(score > 90)
            {Console.WriteLine(score);
                break;
              }
                
        }
        // (c) Calculate class average excluding scores below 40

        int sum = 0;
        int count = 0;

        foreach (int score in scores)
        {
            if (score >= 40) 
            {
                sum += score;
                count++;
            }
        }

        double average = count > 0 ? (double)sum / count : 0;
        Console.WriteLine("\nClass average (excluding <40): " + average);

        // (d) Count students in each grade range
        int gradeA = 0, gradeB = 0, gradeC = 0, gradeD = 0, gradeF = 0;

        foreach (int score in scores)
        {
            if (score >= 90)
                gradeA++;
            else if (score >= 80)
                gradeB++;
            else if (score >= 70)
                gradeC++;
            else if (score >= 60)
                gradeD++;
            else
                gradeF++;
        }

        Console.WriteLine("\nGrade Distribution:");
        Console.WriteLine("A (90-100): " + gradeA);
        Console.WriteLine("B (80-89): " + gradeB);
        Console.WriteLine("C (70-79): " + gradeC);
        Console.WriteLine("D (60-69): " + gradeD);
        Console.WriteLine("F (Below 60): " + gradeF);
        */

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Part 1: Enums

        Console.Write("Enter a day number (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Invalid day number!");
            return;
        }
        dayNumber = dayNumber - 1;

        DayOfWeek day = (DayOfWeek)dayNumber;

        Console.WriteLine("Day: " + day);

        switch (day){
            case DayOfWeek.Saturday:
            case DayOfWeek.Friday:
                Console.WriteLine("it's a Weekend");
                break;
            default:
                Console.WriteLine("it's a Workday");
                break;

        }
        /////////////////////////////////////////////////////////////////////////////////////////
         //Part 2: Arrays
         //Q1 : Array Statistics

            // Ask for array size
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            // Read elements from user
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Initialize variables
            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];

            // Process array
            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }

            double average = (double)sum / size;

            // Print results
            Console.WriteLine("\nSum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);

            // Print array in reverse order
            Console.WriteLine("Array in reverse order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        /////////////////////////////////////////////////////////////////////////////////////////
        //Q2 : Student Grades Matrix



        const int students = 3;
        const int subjects = 4;

        int[,] grades = new int[students, subjects];

        // Read grades from user
        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("Enter grades for Student " + (i + 1) + ":");

            for (int j = 0; j < subjects; j++)
            {
                Console.Write("Subject " + (j + 1) + ": ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        double overallSum = 0;
        int totalGrades = students * subjects;

        Console.WriteLine("\nStudent Averages:");

        // Calculate each student's average
        for (int i = 0; i < students; i++)
        {
            int studentSum = 0;

            for (int j = 0; j < subjects; j++)
            {
                studentSum += grades[i, j];
                overallSum += grades[i, j];
            }

            double studentAverage = (double)studentSum / subjects;
            Console.WriteLine("Student " + (i + 1) + " Average: " + studentAverage);
        }

        // Calculate overall class average
        double overallAverage = overallSum / totalGrades;

        Console.WriteLine("\nOverall Class Average: " + overallAverage);
    }
    }











