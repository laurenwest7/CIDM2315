﻿namespace HW2Q1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num:");
        int a=Convert.ToInt16(Console.ReadLine()); 
        
        Console.WriteLine("Please input the second num:");
        int b=Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Please input the third num:");
        int c=Convert.ToInt16(Console.ReadLine());
   
         int smallest=0;
   
        if(a<b){
            if(a<c){
            smallest=a;
                    }
         }
    
    if(b<a) {
        if(b<c) {
            smallest=b;
        }
    }
    //check if c is the smallest
    if(c<a) {
        if(c<b) {
            smallest=c;
        }
    }
    //print the smallest
    Console.WriteLine("The smallest value is: {0}",smallest);
  }
}
