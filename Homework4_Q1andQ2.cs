


namespace Homework1;
class Program
{
    static void Main(string[] args)
    {

bool flag = true;
    Console.WriteLine("Input an integer: ");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    for(int i=2;i<number/2;i++)
    {
        if(number%i==0)
        {
               flag = false;
               break;
        }
    }
    if(flag)
    {
        Console.WriteLine( input +" is Prime ");
    }
    else{
        Console.WriteLine(input+" is non-prime ");
    }
    }    
}


namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Assign an int value to N: ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0;i<n;i++){
            
        for(int j =0;j<n;j++){
            Console.Write("#");
        }
            Console.WriteLine();
        }
  }

    }



