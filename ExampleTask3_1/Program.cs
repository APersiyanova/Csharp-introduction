// See https://aka.ms/new-console-template for more information
    
using System;
class Example{
    static void Main(){
        Random rand = new Random();
        int number = rand.Next(100,999);
        int[] arr = {number%10,number%100/10,number/100};
        Console.WriteLine("{0}=>[{1}]",number,string.Join(" ",arr));
    }
}