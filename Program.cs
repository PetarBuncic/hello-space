using System;

namespace c_sharp_VSD_Projects
{
    class Program
    
    {
        static public int n;
       public static void Main(String [] args){
            for (int i=0;i<100;i++){
                 int n=i%3;
                 int m=i%5;
                 if(n==0){
                     if(m==0){
                        Console.WriteLine(i +" " + n +" " + m +" Deljiiv sa 3 i 5  ThreeFive" ); 
                     }
                     Console.WriteLine(i +" " + n +" " + m+" Deljiiv sa 3 THree"); 
                 }
                   else  if(m==0){
                     Console.WriteLine(i +" " + n +" " + m+" Deljiiv sa 5 FIVE"); 
                    }
                 else{
                     Console.WriteLine(i +" " + n +" " + m+" NIje Deljiiv NImand"); 
                 }
                 
            }

        }   
    }
}
