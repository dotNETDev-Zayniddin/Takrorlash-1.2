/*
Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. 
For loop dan foydalaning!

*/
using System;
using System.Collections.Concurrent;
namespace Takrorlash
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[5];
            Console.Write("Sonni o'zingiz kiritishni xohlaysizmi?(Ha/Yo'q): ");
            string temp = Console.ReadLine().ToLower();
            if(temp == "ha")
            {
                for(int i = 0; i < myArr.Length; i++)
                {
                    Console.Write($"{i+1}: ");
                    myArr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else if(temp == "yuq" || temp == "yo'q" || temp == "yoq")
            {
                  myArr = new int[5] { 1, 2, 3, 4, 5};
                  foreach(int i in myArr){
                    System.Console.Write(" " + i);
                  }   
            }
            
            int min = myArr[0];
            int max = myArr[0];
            
            for(int i = 0; i < myArr.Length; i++)
            {
                if(max <= myArr[i])
                {
                    max = myArr[i];
                }
                else if(min >= myArr[i]){
                    min = myArr[i];
                }
            } 
        System.Console.WriteLine("Min: " + min +"\t\t|\tMax: " + max);
        System.Console.WriteLine($"Natija = {min*max}"); 
        }
    }
}
