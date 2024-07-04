
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


using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
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



//class Person
//{
//    // variables/fields
//    public string name;
//    public int age;

//    // methods/function

//    //default constractor
//    public Person()
//    {
//        name = "test";
//        age = 15;
//    }

//    //prrameter constractor
//    public Person(string n, int a)
//    {
//        name=n; age=a;
//    }
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Name = {name} Age = {age}\n");
//    }
//}

//class Animal
//{
//    private string name;
//    private string color;
//    private int age;
//    // properties
//    public int Age
//    {
//        get; set;

//    }
//    public string Name
//    {
//        get { return name; }
//        set { if (value.Length >= 3) {
//                name = value;
//            } }
//    }
//    public string Color
//    {
//        get { return color; }
//        set { color = value; }
//    }

//}

//class Test
//{
//    public static void Main(string[] args)
//    {
//        Person p1 = new Person("Nurnoby",26);
//        Console.WriteLine("Person 1");
//        p1.DisplayInfo();
        

//        Person p2 = new Person("Rahim", 20);
//        Console.WriteLine("Person 2");
//        p2.DisplayInfo();

//        Person p3 = new Person();
//        Console.WriteLine("Person 3");
//        p3.DisplayInfo();

//        Animal cat = new Animal();
//        cat.Name = "simba";
//        cat.Age = 1;
//        cat.Color = "white";
//        Console.WriteLine($"Name = {cat.Name} Age = {cat.Age} Color = {cat.Color}\n");


//    }
//}

class Student
{
    // properties
    public string? Name { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string? RollNumber{ get; private set; }
    public int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return DateTime.Now < DateOfBirth.AddYears(age)? age-1 : age;
    }
    //constractor

   public Student(string name, DateTime dateOfBirth, string rollNumber)
    {
        InputValidation(name, dateOfBirth, rollNumber);
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

    public static void InputValidation(string name, DateTime dateOfBirth, string rollNumber)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name can not be null or empty");
        }
        if (dateOfBirth > DateTime.Now)
        {
            throw new ArgumentException("Date of Birth can not be future");
        }
        if (dateOfBirth == default)
        {
            throw new ArgumentException("Date of Birth can not be null or empty");
        }
        if (string.IsNullOrEmpty(rollNumber))
        {
            throw new ArgumentException("Roll Number can not be null or empty");
        }
    }

    public void Display()
    {

        Console.WriteLine($"Name : {Name} Date of Birth : {DateOfBirth.ToShortDateString()}" +
            $" Roll Number : {RollNumber} Age : {CalculateAge()}");
    }
}
class StudentManagement
{
    public static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student("nurnoby", new DateTime(1998, 06, 24), "12588");
            Student student2 = new Student("rahim", new DateTime(2001, 06, 24), "1258");
            Console.WriteLine("Student Details");
            Console.WriteLine("-----------------");
            student1.Display();
            student2.Display();
        }
        catch (Exception ex) {
            Console.WriteLine($"Error : {ex.Message}");
        }

        //string[] names = { "nurnoby, rahim, rineira","alicent","demon" };
        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        int[] numbers = { -20, 30 ,-90,50,40,-52,0};
        int[] posativeNumber = new int[20];
        int sum = 0;
        //for (int i = 0; i < numbers.Length; i++) {
        //    sum = sum + number[i];
        //}
        foreach(int number in numbers)
        {
            if (number > 0) {
                Console.WriteLine(number);
            }
        }

        // matrix array
        int[,] matrix = { { 1,2,3},{4,5,6 } };
        for (int row = 0; row < matrix.GetLength(0); row++) 
        { 
            for(int col =0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
        //jacket array

        //    int[][] jeckedArray =
        //    {
        //     new [] {1,2,3},
        //     new [] { 1 },
        //     new [] { 2, 3 },
        //     new [] { 1, 2, 3, 4, 5, 6 }
        //};

        int[][] jeckedArray = new int[4][];
        jeckedArray[0]= new int[] {1,2,3};
        jeckedArray[1]= new int[] {1};
        jeckedArray[2]= new int[] {2,3};
        jeckedArray[3]= new int[] {1,2,3,4,5,6};

        //for (int row = 0; row <= jeckedArray.Length; row++)
        //{
        //    for (int col = 0; col < jeckedArray[row].Length; col++)
        //    {
        //        Console.Write($"{jeckedArray[row][col]} ");
        //    }
        //    Console.WriteLine();
        //}

        foreach (var row in jeckedArray)
        {
            foreach (var items in row)
            {

                Console.Write( items ); 
            }

            Console.WriteLine();
        }

        // array
        try {
            Console.Write("\n \nHow many number you want : ");
            int size = InputValid();
            int[] digites = new int[size];
            int summation = 0;
            double avg= 0;


            // input from user
            for (int i = 0; i < digites.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int digit = InputValid();
                digites[i] = digit;
            }
            // find max or min value
            int maxDigit = digites[0];
            int minDigit = digites[0];
            for (int i = 1; i < digites.Length; i++)
            {
             
                if(maxDigit < digites[i])
                {
                    maxDigit = digites[i];
                }
                if(minDigit > digites[i])
                {
                    minDigit = digites[i];
                }

            }
            // sum all value

            foreach(var digite in digites)
            {
                summation += digite;
            }
            // avarage
           avg =(float) summation/digites.Length;

            Console.WriteLine($"max = {maxDigit}");
            Console.WriteLine($"min = {minDigit}");
            Console.WriteLine($"summation = {summation}");
            Console.WriteLine($"avarage = {avg:F2}");
        } catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        //filterting with where
        List<int> list = new List<int> { 1, 3,  5,  7, };
        var evenNumber = list.Where(num => num % 2 == 0);
        Console.WriteLine($"Even number count : {evenNumber.Count()}");
        if (evenNumber.Any())
        {
            Console.Write($" Even Number : ");
            foreach (var digite in evenNumber)
            {
                Console.Write($"{digite} ");
            }
            Console.WriteLine();
        } else {
            Console.WriteLine($"No even number  ");
        }
        // filtering with where for words

        List<string> fruits = new List<string> { "apple","orange","mango","lichu","banana" };
        var longFruits = fruits.Where(fruit => fruit.Length > 5);

        Console.WriteLine($"LongFruits count : {longFruits.Count()}");
        if (longFruits.Any())
        {
            Console.Write($" LongFruits : ");
            foreach (var digite in longFruits)
            {
                Console.Write($"{digite} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No LongFruits  ");
        }










    }
    public static int InputValid()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.Write("Envalid number. Enter a enteger number : ");
            }
        }
       
    }
}
