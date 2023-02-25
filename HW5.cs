
//Q1 CODE
namespace Homework5;
using System;
class Program{
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
    }
}


//Q2 Code 
namespace Homework5;
using System;
class Program{
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}


//Q3 Code 
namespace Homework5;
using System;
class Program{
    public static void Main(string[] args)
{

createAccount();
Console.ReadKey(true);
}
public static bool checkAge(int birth_year)
{

int age=2022-birth_year;

if(age>=18)
return true;

else
return false;
}
public static void createAccount()
{

String userName,password,retypedPassword;
int birthYear;
Console.WriteLine("Enter Your Username:");
userName=Console.ReadLine();
Console.WriteLine("Enter Your Password:");
password=Console.ReadLine();
Console.WriteLine("Enter Your Password Again:");
retypedPassword=Console.ReadLine();
Console.WriteLine("Enter Your Birthyear:");

birthYear=Convert.ToInt32(Console.ReadLine());

if(checkAge(birthYear))
{

if(password==retypedPassword)
Console.WriteLine("Account is created successfully");

else
Console.WriteLine("Wrong password");
}

else
Console.WriteLine("Could not create an account.");
}
}



