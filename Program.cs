using System;

class program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Please enter marks of paper");
        int Mark = Convert.ToInt32(Console.ReadLine());
        int grade = GetGrade(Mark);
         Console.WriteLine("This is your grade: " + GetGrade(Mark));
    }

    static int GetGrade(int Mark)
    {
        if (Mark >= 90)
        {
            return 1; // A
        }
        else if (Mark >= 80)
        {
            return 2; // B
        }
        else if (Mark >= 70)
        {
            return 3; // C
        }
        else if (Mark >= 60)
        {
            return 4; // D
        }
        else
        {
            return 5; // F
        }

    }

   
}
    
