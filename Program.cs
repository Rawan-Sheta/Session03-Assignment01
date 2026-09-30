using System;

internal class Person
{
    public string Name { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {


        /* Assignment 1
         ======================================================================================================*/

        #region Q01
        // 1-	Write a program that allows the user to enter a number then print it.

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You entered: " + number);

        #endregion

        #region Q02
        // 2 -	Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

        // in this code parse throws an exception because the string isn't a valid integer
        //string text = "rawan777";
        ////int a = int.Parse(text);
        //// but in this syntax tryparse does not throw an exception ,it returns false and sets result to 0
        //bool ok = int.TryParse(text, out int result);
        //Console.WriteLine(ok);
        //Console.WriteLine(result);

        #endregion

        #region Q03
        //3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        //double x = 0.1;
        //double y = 0.2;
        //double sum = x + y;
        //Console.WriteLine(sum);
        //Console.WriteLine(sum == 0.3);
        //// 0.1 and 0.2 can't be represented exactly in binary, so a tiny error appears and the comparison with 0.3 is false
        #endregion

        #region Q04
        ////4-	write c# program that extract a substring from a given string.
        //string s = "my name is rawan!";
        //string sub = s.Substring(7, 5);
        //Console.WriteLine(sub);
        #endregion

        #region Q05
        ////5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        //int a = 10;
        //int b = a;     
        //b = 20;
        //Console.WriteLine(a);   //10
        //Console.WriteLine(b);   //20

        #endregion

        #region Q06
        ////6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        //Person p1 = new Person { Name = "Rawan" };
        //Person p2 = p1;         
        //p2.Name = "Sara";
        //Console.WriteLine(p1.Name);   // Sara
        //Console.WriteLine(p2.Name);   // Sara

        #endregion

        #region Q07
        //7-	Write C# program that take two string variables and print them as one variable 
        //string first = "Rawan";
        //string second = "Sheta";

        //string full = first + " " + second;
        //string full2 = $"{first} {second}";

        //Console.WriteLine(full);    // Rawan Sheta
        //Console.WriteLine(full2);   // Rawan Sheta

        #endregion

        #region Q08
        /*8-	Which of the following statements is correct about the C#.NET code snippet given below?
        int d; 
        d = Convert.ToInt32( !(30 < 20) );
        a)	A value 0 will be assigned to d.
        b)	A value 1 will be assigned to d.
        c)	A value -1 will be assigned to d.
        d)	The code reports an error.
        e)	The code snippet will work correctly if ! is replaced by Not.
        Answer is: b)	A value 1 will be assigned to d.

        */
        //int d;
        //d = Convert.ToInt32(!(30 < 20));
        //Console.WriteLine(d); // Output: 1
        #endregion

        #region Q09
        /* 9-	Which of the following is the correct output for the C# code given below?
        Console.WriteLine(13 / 2 + " " + 13 % 2); 
        a)	6.5 1
        b)	6.5 0
        c)	6 0
        d)	6 1
        e)	6.5 6.5

         Answer is: d)	6 1  
        "/" given the result of integer division, which is 6. "%" gives the remainder of the division, which is 1. The output is "6 1".
         */

        #endregion

        #region Q10

        /* 10-What will be the output of the C# code given below?
        int num = 1, z = 5;
        if (!(num <= 0))
            Console.WriteLine( ++num + z++ + " " + ++z ); 
        else
            Console.WriteLine( --num + z-- + " " + --z ); 
        a)	5 6
        b)	6 5
        c)	6 6
        d)	7 7
        Answer is:
        d)	7 7
        The condition !(num <= 0) is !(false), which is true, so the if branch runs.
        In ++num + z++ + " " + ++z, C# evaluates left to right:
        ++num (pre-increment) makes num 2 and gives 2.
        z++ (post-increment) gives the old value 5, then z becomes 6.
        2 + 5 is integer addition and gives 7, before any string is involved.
        + " " gives "7 ".
        ++z makes z 7 and gives 7, so the result is "7 7".

        */
        #endregion

    }
}
