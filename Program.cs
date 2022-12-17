//using System;
//class Program
//{


//    public static void Main()
//    {
//// Addition of two numbers

//int num1;
//int num2;

//Console.WriteLine("Please input first number");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please input second number");
//num2 = Convert.ToInt32(Console.ReadLine());

//int result = num1+ num2;
//Console.WriteLine("Addition of two numbers is {0}", result);



//// Subtraction of two numbers

//int numb1;
//int numb2;

//Console.WriteLine("Please input first number");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please input second number");
//num2 = Convert.ToInt32(Console.ReadLine());

//int result1 = num1 - num2;
//Console.WriteLine("Subtraction of two numbers is {0}", result1);


//// Multiplication of two numbers

//int numbe1;
//int numbe2;

//Console.WriteLine("Please input first number");
//numbe1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please input second number");
//numbe2 = Convert.ToInt32(Console.ReadLine());

//int result2 = numbe1 * numbe2;
//Console.WriteLine("Multiplication of two numbers is {0}", result2);


//// Division of two numbers

//int x = 5;
//int y = 6;
//int result = x + y;    
// Console.WriteLine("Addition of two numbers is {0}",result);


//// Movie Ticket

//Console.WriteLine("Hello! If you want ticket then insert the cash");
//int cash = Convert.ToInt32(Console.ReadLine());

//if (cash < 5)
//{
//    Console.WriteLine("Cash is not enough");
//}
//else if (cash == 5)
//{
//    Console.WriteLine("Here is your ticket");
//}
//else 
//{
//    int change = cash - 5;
//    Console.WriteLine("Here is your ticket and   "+change+" is your balance amount ");

//}
//Console.ReadKey(); 

//// Rolercoaster entry

//int age;
//int height;

//Console.WriteLine("Please input your age");
//age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("please input your height(in cm)");
//height = Convert.ToInt32(Console.ReadLine());

//if(age >= 15 || height >= 100)
//    {
//    Console.WriteLine("You can enter");
//    }
//else
//{
//    Console.WriteLine("You cannot enter");
//}

//Console.ReadKey();  

//// Switch Statement Program

//Console.Write("Please input number 1 and 5 : ");
//int num = Convert.ToInt32(Console.ReadLine());  

//switch(num) 
//{
//    case 1:
//        Console.WriteLine("One");
//        break;

//    case 2:
//        Console.WriteLine("Two");
//        break;  
//    case 3:
//        Console.WriteLine("Three");
//        break;
//    case 4: 
//        Console.WriteLine("Four"); 
//        break;  
//     case 5: 
//        Console.WriteLine("Five"); 
//        break;
//    default:
//        Console.WriteLine("default");
//        break;

//        Console.ReadKey();
//}


//// Program to for loop

//Console.Write("Please enter your target : ");
//int target = Convert.ToInt32(Console.ReadLine());

//int i;
//for(i=1;i<=target;i++)
//{
//    Console.WriteLine(i);

//}

//// Squareroot of numbers

//Console.Write("Please input your target : ");
//int target = Convert.ToInt32(Console.ReadLine());

//int i;
//for (i = 1; i <= target; i++) 
//{
//  double result = Math.Sqrt(i);
//    Console.WriteLine(result);  
//}
//Console.ReadKey();  

//// While loop
//Console.WriteLine("please enter the input");
//int target = Convert.ToInt32(Console.ReadLine());

//int i = 0;
//while (i <= target)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i + " ");
//    }
//    i = i + 2;
//}
//Console.ReadKey();

//        //own program to while loop

//        Console.Write("Please enter input : ");
//        int target = Convert.ToInt32(Console.ReadLine());

//        int i = 0;
//        while (i <= target)
//        {
//            if (i % 2 == 0)
//            {
//                Console.WriteLine(i + " ");
//            }
//            i = i + 2;
//        }
//        Console.ReadKey();

//// program to print odd numbers by using while loop

//Console.WriteLine("please input your target");
//int target = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//while (i <= target)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i + " ");
//    }
//    i++;
//}
//Console.ReadKey();


////Array
//string[] movies = new string[4];
//Console.WriteLine("Type in four movies : ");

//for (int i = 0;i<movies.Length; i++)
//{
//    movies[i] = Console.ReadLine();
//}


//Console.ReadKey();

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//for (int i = 0; i < numbers.Length; i++)
//{

//    Console.WriteLine(numbers[i]);

//}

//Console.ReadKey();  

////sorting of elements in array
//string[] student = new string[7];
//Console.WriteLine("please input names of seven students : "); 
//for (int i = 0;i< student.Length;i++)
//{
//    student[i] = Console.ReadLine();
//}
//Console.WriteLine("now we arrange in the alphabetical order");
//Array.Sort(student);
//for (int i = 0; i < student.Length; i++)
//{
//    Console.WriteLine(student[i]);
//}


//Console.ReadKey();  

//// Sum of array of elements
//int[] numbers = new int[15];

//int i, n, sum = 0;
//Console.WriteLine("please input the length of array : ");
//n =  Convert.ToInt32(Console.ReadLine());

//Console.Write("Input {0} elements in the array :\n", n);
//for (i=0;i<n; i++)
//{
//    Console.WriteLine("element - {0} : ", i);
//   numbers[i] = Convert.ToInt32(Console.ReadLine());    
//}

//for(i=0;i<n;i++)
//{
//    sum+= numbers[i];

//}
//Console.WriteLine("Sum of array elements is : {0}", sum);

//Console.ReadKey();      
//   }
//}

//// Program for List
//using System;
//using System.Collections.Generic;

//class Program
//{
//    public static void Main()
//    {
//        List<string> student = new List<string>();

//        student.Add("Surya");
//        student.Add("Hema");
//        student.Add("Sri");
//        student.Add("Manasa");
//        student.Add("Rashmi");

//        for (int i=0;  i < student.Count; i++)
//        {
//            Console.WriteLine(student[i]);
//        }

//        Console.WriteLine("I want these names only");
//        Console.WriteLine("\n");

//        student.RemoveAt(student.Count - 1);
//        student.RemoveAt(student.Count - 3);

//        for (int i = 0; i < student.Count; i++)
//        {
//            Console.WriteLine(student[i]);
//        }




//        Console.ReadKey();
//    }
//}

using System;

class Program
    {

        public static void Main(String[] args)
        {
            int result = Multiply(5, 6);

            Console.WriteLine("Multiplication of two numbers is :  "+ result);
            Console.ReadKey();  
        }

         static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;

        }
    }




