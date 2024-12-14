namespace assig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter Number");
            //int num = int.Parse (Console.ReadLine());
            //Console.WriteLine($"Your Num : {num}");

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string input = "mss22";
            //int num = int.Parse(input);
            // Console.WriteLine(num);
            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //double num1 = 0.1;
            //double num2 = 0.2;
            //double sum = num1 + num2;
            //Console.WriteLine(sum);

            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.

            //string subStr = originalString.Substring(0, 5);
            //Console.WriteLine(subStr);


            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
           // int a = 5;
            //  int b = 10;
              //a = b;
               //b = 20;
               //Console.WriteLine(a);
               //Console.WriteLine(b);


            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
                    //int[] arr1 = { 1, 2, 3 };
                    //int[] arr2 = arr1;
                    //arr2[0] = 100;
                    //Console.WriteLine("Arr1[0]"+ arr1[0]);
                    //Console.WriteLine("Arr2[0]"+ arr2[0]);
            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
                    //string s1, s2, s3;
                    //s1 = Console.ReadLine();
                    //s2 = Console.ReadLine();
                    //s3 = s1 + s2;
                    //Console.WriteLine(s3);


            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
                    // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.
                    //Console.Write("Enter the principal amount: ");
                    // double principal = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("Enter the rate of interest (in %): ");
                    //double rate = Convert.ToDouble(Console.ReadLine());
                    // Console.Write("Enter the time (in years): ");
                    // double time = Convert.ToDouble(Console.ReadLine();
                    // double interest = (principal * rate * time) / 100;
                    //Console.WriteLine($"The simple interest is: {interest}");
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
                    // Note: The formula for BMI is BMI = (Weight) / (Height * Height)

                    //Console.Write("Enter your weight in kilograms: ");
                    //double weight = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("Enter your height in meters: ");
                    //double height = Convert.ToDouble(Console.ReadLine());
                    // double bmi = weight / (height * height);
                    // Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi:F2}");
                    // if (bmi < 18.5)

                    // {
                    //  Console.WriteLine("You are underweight.");
                    // }

                    // else if (bmi < 25)

                    //{
                    //    Console.WriteLine("You are normal weight.");

                    // }
                    // else if (bmi < 30)
                    // {

                    //     Console.WriteLine("You are overweight.");
                    // }
                    //else

                    // {
                    //     Console.WriteLine("You are obese.");
                    //}
            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
                    ///that below 10 degrees is "Just Cold"
                    ///above 30 degrees is "Just Hot"
                    ///anything else is "Just Good"


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
                    ///Ex:
                    ///Today’s date : 20 , 11 , 2001
                    ///Today's date : 20 / 11 / 2001
                    ///Today's date : 20 – 11 – 2001
                    // Console.WriteLine("Please enter a date (format: dd/MM/yyyy):");
                    //string input = Console.ReadLine();
                    // if (DateTime.TryParse(input, out DateTime date))

                    // {
                    //   Console.WriteLine($"Today's date: {date.Day}, {date.Month}, {date.Year}");
                    //  Console.WriteLine($"Today's date: {date.Day} / {date.Month} / {date.Year}");
                    //   Console.WriteLine($"Today's date: {date.Day} – {date.Month} – {date.Year}");
                    //  }
                    //  else
                    // {

                    //    Console.WriteLine("Invalid date format. Please enter a valid dat")
                    //}
            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
                    ///Example(1)
                    ///Input: 12
                    ///Output: Yes
                    ///Example(2)
                    ///Input: 9
                    ///Output: No
                    //  Console.Write("Enter a number: ");
                    // int number;
                    // if (int.TryParse(Console.ReadLine(), out number))
                    // {

                    //    if (number % 3 == 0 && number % 4 == 0)

                    //   {
                    Console.WriteLine("Yes");
             //   }

       ///  else

       //  {
       //     Console.WriteLine("No");
       //  }
       //    }

       //  else

       //  {
       //    Console.WriteLine("Invalid input. Please enter a valid integer.");
       /// }

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
       ///Example(1)
       ///Input: -5
       ///Output: negative
       ///Example(2)
       ///Input: 10
       ///Output: positive
       // Console.Write("Enter an integer: ");
       // int number;
       // int.TryParse(Console.ReadLine(), out number))

       //    if (number < 0)

       //   {
       //      Console.WriteLine("negative");
       //  }
       //  else

       //  {
       //       Console.WriteLine("positive");
       //   }
       //  }

       //  else

       // {
       //    Console.WriteLine("Invalid input. Please enter a valid integer.");
       //}



            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
       ///Example(1)
       ///Input: 7,8,5
       ///Output:
       ///max element = 8
       ///min element = 5
       ///Example(2)
       ///Input: 3 6 9
       ///Outputs:
       ///Max element = 9
       ///Min element = 3




            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
       // Console.Write("Enter an integer: ");
       //int number;
       //(int.TryParse(Console.ReadLine(), out number))
       // if(number % 2 == 0)
       //  {
       // Console.WriteLine("Even");

       //  }
       // else

       // {
       //    Console.WriteLine("Odd");
       // }

       // else{
       
         // Console.WriteLine("Invalid input. Please enter a valid integer.");
         //  }



            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31


            #endregion

    }
    }
}

      
   