
using System;
using System.Linq;

class Program 
{
  public static void Main (string[] args)
  {  
     int i,j=0,k=0,a,Esum=0,Osum=0;   
          
          int[] EvenNum = new int[10];
          int[] OddNum = new int[10];   
    
            for (i = 0; i < 10; i++) 
            { 
              Console.WriteLine("Enter array element:"); 
              a= Convert.ToInt32(Console.ReadLine()); 
                if (a % 2 == 0) 
                {  
                    EvenNum[j] = a;
                    j++;
                      
                } 
                else 
                {  
                    OddNum[k] = a;
                    k++;  
                }  
            }  
    Console.WriteLine("\nEven Array is: ");
    for(i=0;i<j;i++)
      {
       Esum += EvenNum[i];
	      Console.Write("{0} ", EvenNum[i]); 
      }  
    
    Console.WriteLine("\nOdd Array is: ");
    for(i=0;i<k;i++)
      {
      Osum += OddNum[i]; 
	      Console.Write("{0} ",OddNum[i]);
      } 

    int[] sortedEven = EvenNum.OrderBy(i => i).ToArray();
    int[] sortedOdd = OddNum.OrderByDescending(i => i).ToArray();
    
    Console.WriteLine("\nThe Even array in ordered form is: "); 
    foreach (int Even in sortedEven)
     Console.WriteLine(Even + " ");

    Console.WriteLine("The Odd array in ordered form is: " );   
    foreach (int Odd in sortedOdd)
    Console.WriteLine(Odd + " ");

    
    Console.WriteLine("Sum of even array is: " + Esum); 
  
    Console.WriteLine("Sum of odd array is: " + Osum);  
  
  
    
  }
}


  