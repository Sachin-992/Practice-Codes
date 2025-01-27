using System;
namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }

                Console.WriteLine($"Your total including the bonus: {total}");
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }


            int num1 = 10;
            int num2 = 20;
            int largenum = Math.Max(num1, num2);
            Console.WriteLine($"The Maximum Value is : {largenum}");
       



            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

        
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text); 

            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;
            Console.WriteLine("Course\t\tGrade");
            Console.WriteLine($"{course1Name}\t{course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} \t{course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} \t{course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} \t{course5Grade} {course5Credit}");

            Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
          
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSum = 0;
            int nicolasSum = 0;
            int zahirahSum = 0;
            int jeongSum = 0;

            int sophia_sum = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);
            Console.WriteLine("sophia_sum: " + sophia_sum);

            int nicolas_sum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);
            Console.WriteLine("nicolas_sum: " + nicolas_sum);

            int zahirah_sum = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);
            Console.WriteLine("zahirah_sum: " + zahirah_sum);

            int jeong_sum = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);
            Console.WriteLine("jeong_sum: " + jeong_sum);



            decimal sophiaScore = (decimal)sophia_sum / currentAssignments;
            decimal nicolasScore = (decimal)nicolas_sum / currentAssignments;
            decimal zahirahScore = (decimal)zahirah_sum / currentAssignments;
            decimal jeongScore = (decimal)jeong_sum / currentAssignments;

            Console.WriteLine("Sophia: " + sophiaScore);
            Console.WriteLine("Nicolas: " + nicolasScore);
            Console.WriteLine("Zahirah: " + zahirahScore);
            Console.WriteLine("Jeong: " + jeongScore); 

            /* 97 - 100    A+
            93 - 96     A
            90 - 92     A-
            87 - 89     B+
            83 - 86     B */


            Console.WriteLine("Student\t\tGrade\n");

            Console.WriteLine("Sophia:\t\t " + sophiaScore + " \tA");
            Console.WriteLine("Nicolas:\t " + nicolasScore + " \tB");
            Console.WriteLine("Zahirah:\t " + zahirahScore + " \tB");
            Console.WriteLine("Jeong:\t\t " + jeongScore + " \tA");

            string color = Console.ReadLine();

            switch (color.ToLower())
            {
                case "green":
                    Console.WriteLine("You selceted green");
                    break;

                case "red":
                    Console.WriteLine("selected red color");
                    break;
                case "yellow":
                    Console.WriteLine("selcted yellow color");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }




            Console.Write("Enter your age:");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine($"Your Enter Age:{age}");

            if (age > 18)
            {
                if (age > 20 && age < 25)
                {
                    Console.WriteLine("Not permitted to drink");
                }
                Console.WriteLine("Not permitted");
            }
            else
            {
                Console.WriteLine("Permitted");
            }






            bool result = (a == b);
            Console.WriteLine(result);
        }
    }
}