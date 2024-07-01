
//class TypeCasting()
//{
//    public static void Main(string[] args)
//    {
//        string? studentName;
//        int age;
//        double gpa;
//        bool isRegistred;

//        Console.WriteLine("Enter your name: ");
//        studentName = Console.ReadLine();

//        Console.WriteLine("Enter your age");
//        age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter your gpa");
//        gpa = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Are you registred ? true or false");
//        isRegistred = Convert.ToBoolean(Console.ReadLine());

//        Console.WriteLine("Name : "+studentName);
//        Console.WriteLine("Age  : "+age + " years old");
//        Console.WriteLine("GPA  : "+gpa);
//        Console.WriteLine("Is Registred  : "+isRegistred);

//    }
//}

//class Assignment4()
//{
//    public static void Main(string[] args)
//    {
//        // 1 task
//        //int number1, number2;
//        //int result;
//        //Console.WriteLine("Enter a number1");
//        //number1= Convert.ToInt32(Console.ReadLine());

//        //Console.WriteLine("Enter a number2");
//        //number2 = Convert.ToInt32(Console.ReadLine());

//        //result = number1 + number2;
//        //Console.WriteLine("{0}+{1}={2}", number1,number2,result);

//        //result = number1 - number2;
//        //Console.WriteLine("{0}-{1}={2}", number1, number2, result);

//        //result = number1 * number2;
//        //Console.WriteLine("{0}*{1}={2}", number1, number2, result);

//        //double div = (double) number1 / number2;
//        //Console.WriteLine("{0}/{1}={2}", number1, number2, div.ToString("F3"));

//        //result = number1 % number2;
//        //Console.WriteLine("{0}%{1}={2}", number1, number2, result);

//        //double avg = (double)(number1  + number2) / 2;
//        //Console.WriteLine("{0}avg{1}={2}", number1, number2, avg);

//        //2nd task

//        //double lenth = 20;
//        //double weidh = 30;
//        //double redius = 50;
//        //double result;

//        //result = .5 * lenth * weidh;
//        //Console.WriteLine($"Tringle = {result}");

//        //result = 3.1416* redius*2;
//        //Console.WriteLine($"Circle = {result}");

//        //result = lenth * weidh;
//        //Console.WriteLine($"Ractengle = {result}");

//        // 3rd task

//        //double temp = 41;
//        //double result;

//        //result =  (temp * 9 / 5) + 32;
//        //Console.WriteLine($"Temperature = {result}");


//        // Reletion/conpariton oparator
//        //int num1 = 50;
//        //int num2 = 60;
//        //int larger;
//        //bool result;
//        //result = num1 != num2;
//        //Console.WriteLine($"{num1}=={num2}={result}");
//        //Console.WriteLine(num1 != num2);
//        //// unary operator
//        //Console.WriteLine("Unary operator");
//        //Console.WriteLine(num1++);
//        //Console.WriteLine(--num1);

//        //// tarnary operator
//        //larger= num1 < num2 ? num2 : num1;
//        //Console.WriteLine(larger);

//        // check given number odd or even

//        int number1 ,number2,number3;
//        Console.Write("Enter  number1 = ");
//        number1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter number2 = ");
//        number2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter number3 = ");
//        number3 = Convert.ToInt32(Console.ReadLine());

//        if (number1 > number2 && number1 > number3)
//        {
//            Console.WriteLine($"{number1} large number");
//        }
//        else if (number2 > number1 && number2 > number3)
//        {
//            Console.WriteLine($"{number2} large number");
//        }
//        else if (number3 > number1 && number3 > number2)
//        {
//            Console.WriteLine($"{number3} large number");
//        }
//        else { Console.WriteLine("All number are equal"); }






//    }
//}

//class Assignment9()
//{
//    public static void Main(string[] args)
//    {
//        //int number;
//        //Console.Write("Entar your mark = ");
//        //number = Convert.ToInt32(Console.ReadLine());

//        //if(number >0 && number <= 100)
//        //{
//        //    if (number >=90  ) {
//        //        Console.WriteLine("A");
//        //    }
//        //    else if (number >= 80 )
//        //    {
//        //        Console.WriteLine("B");
//        //    }
//        //    else if (number >= 70 )
//        //    {
//        //        Console.WriteLine("C");
//        //    }
//        //    else if (number >= 60 )
//        //    {
//        //        Console.WriteLine("D");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("F");
//        //    }

//        //}
//        //else
//        //{
//        //    Console.WriteLine($"{number} Invalide number");
//        //}

//        // leap year

//        //if (number % 400 == 0 || (number%4 == 0 && number%100 !=0))
//        //{
//        //    Console.WriteLine($"{number} leap year");
//        //}
//        //else { Console.WriteLine("NOT leap year"); }

//        char letter;
//        Console.WriteLine("Entar a latter");
//        letter = Convert.ToChar(Console.ReadLine());

//        //if(letter >= 'A' && letter<='Z')
//        //{
//        //    Console.WriteLine($"{letter} it is capital letter");
//        //}
//        //else
//        //{
//        //    Console.WriteLine($"{letter} small letter");
//        //}
//        switch (Char.ToLower(letter)) { 
//        case 'a':
//        case 'e':
//        case 'i':
//        case 'o':
//        case 'u':
//                Console.WriteLine("vowel");
//            break;
//         default:
//                if (Char.IsLetter(letter))
//                {
//                    Console.WriteLine("consonent");
//                }
//                else { Console.WriteLine("not letter"); }
//             break;



//        }
//    }
//}

using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;



class Method()
{
    public static void Message(string text)
    {
        Console.WriteLine(text);
    }

    public static void Add(int number1 , int number2)
    {
        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
    }

    public static void Sub(int number1, int number2)
    {
        int result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");
    }
    public static int Square(int number)
    {
        int result = number * number;
       return result;
    }
    public static void Main(string[] args)
    {
        Message("Welcome to calculator");
        Add(20, 30);
        Sub(20, 30);
        int result = Square(20);
        Console.WriteLine($"Square of 20 is {result}");

        Message("Thank You");

    }
}