﻿
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

//class Assignment10()
//{
//    public static void Main(string[] args)
//    {
//        //string day;
//        //Console.WriteLine("Enter a day of the week");
//        //day = Convert.ToString(Console.ReadLine());

//        //switch (day.ToLower())
//        //{
//        //    case "sunday":
//        //    case "monday":
//        //    case "tuesday":
//        //    case "wednesday":
//        //    case "thusday":
//        //        Console.WriteLine("weekday");
//        //        break;
//        //    case "firday":
//        //    case "saturday":
//        //        Console.WriteLine("weekend");
//        //        break;
//        //    default:
//        //        Console.WriteLine("is not valid day");
//        //        break;



//        //}
//        // short switch

//        //string message = day.ToLower() switch
//        //{
//        //    "sunday"=> "weekday",
//        //    "monday"=> "weekday",
//        //    "tuesday" => "weekday",
//        //    "wednesday" => "weekday",
//        //    "thusday" => "weekday",
//        //    "firday" => "weekend",
//        //    "saturday" => "weekend",
//        //    _=> "is not valid day"
//        //};
//        //Console.WriteLine(message);

//        //object number = 5.5;
//        //string message = number switch
//        //{
//        //    int => "integer",
//        //    float => "float",
//        //    double => "double",
//        //    string => "string",

//        //    _ => "Char"
//        //};
//        //Console.WriteLine(message);
//        // switch statement a conditon use
//        // Console.WriteLine("Enter a number");


//        //switch (number)
//        //{ 
//        //    // switch case a conditon use korte hole when use korte hobe
//        //    case int num when num < 1 || num >10:
//        //        Console.WriteLine("Number is out of range");
//        //        break;
//        //    case int num when num%2==0 :
//        //        Console.WriteLine("Even number");
//        //        break;
//        //    default:
//        //        Console.WriteLine("Odd number");
//        //        break;
//        //}
//        // short switch
//        //if (int.TryParse(Console.ReadLine(), out int number))

//        //{
//        //    string result = number switch
//        //    {
//        //        int num when (num >= 1 && num <= 10) => num % 2 == 0 ? $"{num} Even number" : $"{num} Odd number",
//        //        _ => number + " is out of range"
//        //    };
//        //    Console.WriteLine(result);
//        //}
//        //else
//        //{
//        //    Console.WriteLine("invalide number");
//        //}


//        // Tmperature convater 
//        //Console.WriteLine("Temperatue Convertar Started");
//        //Console.WriteLine("Prass 1. Faharheeit to Celsisus");
//        //Console.WriteLine("Prass 2. Celsisus to Faharheeit");
//        //int number = Convert.ToInt32(Console.ReadLine());
//        //switch(number)
//        //{
//        //    case 1:
//        //        Console.WriteLine("Enter temperature");
//        //         double farh = Convert.ToDouble(Console.ReadLine());
//        //        Console.WriteLine((farh - 32) * 5 / 9);
//        //        break;
//        //    case 2:
//        //        Console.WriteLine("Enter temperature");
//        //        double cel = Convert.ToDouble(Console.ReadLine());
//        //        Console.WriteLine((cel * 9 / 5) + 32);
//        //        break;
//        //    default:
//        //        Console.WriteLine("Invalid Choise");
//        //        break;
//        //};

//        // loop
//        int number = 100;
//        for (int i = 1; i <= number; i++)
//        {
//            Console.WriteLine(i);
//        }
//        // revese
//        int last = 1;
//        for (int i = 100; i >= last; i--)
//        {
//            Console.WriteLine(i);
//        }

//        //1-100 odds number

//        for (int i = 1; i <= 100; i = i + 2)
//        {
//            Console.WriteLine(i);
//        }

//        // 1-100 even number

//        for (int i = 1; i <= 100; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.WriteLine(i);
//            }

//        }


//        Console.WriteLine("Enter stating number");
//        int start = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter stating number");
//        int end = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter stating number");
//        int diff = Convert.ToInt32(Console.ReadLine());

//        for (int i = start; i <= end; i = i + diff)
//        {
//            Console.WriteLine(i);
//        }

//        // 1-100 even number sum
//        int sum = 0;
//        for (int i = 1; i <= 10; i++)
//        {
//            if (i % 2 == 0)
//            {
//                sum = sum + i;
//            }

//        }
//        Console.WriteLine(sum);

//        // fectorial number

//        int fec = 1;
//        for (int i = 1; i <= 5; i++)
//        {
//            fec = fec * i;

//        }
//        Console.WriteLine(fec);

//        Console.WriteLine("Enter a number");
//        int number = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"{number} X {i} = {number * i} ");

//        }

//        // 2 theke 8 ghar ar namota

//        Console.WriteLine("Start number");
//        int startNumber = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("End number");
//        int EndNumber = Convert.ToInt32(Console.ReadLine());

//        for(int i = startNumber; i <= EndNumber; i++) 
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine($"{i} X {j} = {i * j} ");
//            }
//            Console.WriteLine("-----------");
//        }



//    }


//}

//class Method()
//{
//    public static void Message(string text)
//    {
//        Console.WriteLine(text);
//    }

//    public static void Add(int number1, int number2)
//    {
//        int result = number1 + number2;
//        Console.WriteLine($"{number1} + {number2} = {result}");
//    }

//    public static void Sub(int number1, int number2)
//    {
//        int result = number1 - number2;
//        Console.WriteLine($"{number1} - {number2} = {result}");
//    }
//    public static int Square(int number)
//    {
//        int result = number * number;
//        return result;
//    }
//    public static void Main(string[] args)
//    {
//        Message("Welcome to calculator");
//        Add(20, 30);
//        Sub(20, 30);
//        int result = Square(20);
//        Console.WriteLine($"Square of 20 is {result}");

//        Message("Thank You");

//    }
//}

//class LoopTemnination()
//{
//    public static void Square(int num)
//    {
//        Console.WriteLine($"{num} square of this number is {num*num}");
//    }
//    public static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("\n ----Entar a number 1 to 10 or write quit to exit this app---");
//            string input = Console.ReadLine() ?? "";
//            input = input.Trim().ToLower();
//            if(input == "quit")
//            {
//                Console.WriteLine("Thank you for using out app. Good bye");
//                break;
//            }
//            if(!int.TryParse(input, out int number))
//            {
//                Console.WriteLine("Entar a valid  number");
//                continue;
//            }
//            if (number <0 || number >10) {
//                Console.WriteLine("Out of valid range");
//                continue;
//            }
//            Square(number);

//        }
//        Console.Read();
//    }
//}



class Person()
{
    // variables/fields
    public string name;
    public int age;

    // methods/function
    public void SetValue(string objectName , int objectAge)
    {
        name = objectName;
        age = objectAge;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name = {name} Age = {age}\n");
    }
}


class Test()
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetValue("Nurnoby", 26);
        Console.WriteLine("Person 1");
        p1.DisplayInfo();
        

        Person p2 = new Person();
        p2.SetValue("Rahim", 20);
        Console.WriteLine("Person 2");
        p2.DisplayInfo();


    }
}