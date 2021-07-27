using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
           int n= int.Parse(Console.ReadLine()); 
           int[,] mat = new int [n, n]; 

           for( int i=0; i<n; i++){
                 string[] valorlinha= Console.ReadLine().Split(' ');

               for (int col =0; col<n; col++){
                   mat[i,col] = int.Parse(valorlinha[col]);

               }

           }
           Console.WriteLine("Diagonal principal");
           for(int i=0; i<n;i++){
               Console.Write(mat[i,i]+ "");
           }
           Console.WriteLine();
       
        int count=0;
       for (int i=0; i<n; i++){
           for (int col =0; col<n; col++){
               if( mat[i,col] <0) {
                   count++;
               }

           }

        }
     Console.WriteLine("A quantidade de numeros negativos são  " +count);

    }
}
}