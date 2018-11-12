using System;

namespace c_sharp_VSD_Projects
{
    class Program
    
    {
       public static void Main(String [] args){
            for (int i=0;i<=100;i++){
                 int n=i%3;
                 int m=i%5;
                 if(n==0){
                     if(m==0){
                        Console.WriteLine(i +" " + n +" " + m + "ThreeFive" ); 
                     }
                     Console.WriteLine(i +" " + n +" " + m+" THree"); 
                 }
                   else  if(m==0){
                     Console.WriteLine(i +" " + n +" " + m+" IVE"); 
                    }
                 else{
                     Console.WriteLine(i +" " + n +" " + m+"no 5 no 3"); 
                 }
                 
            }

        }   
    }
}
