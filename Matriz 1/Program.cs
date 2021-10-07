using System;

namespace Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // entra dos dados 
            int n = int.Parse(Console.ReadLine()); 
            
            int[,] mat = new int[n, n]; 
            
            for (int i = 0; i < n; i++) {

                // esta criando uma matriz de subcadeias
                string[] values = Console.ReadLine().Split(' '); 
                
                
                for (int j = 0; j < n; j++) { 
                    
                    mat[i, j] = int.Parse(values[j]); 
                } 
            }
            // esta mostrando a diagonal principal 
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++) {
                
                Console.Write(mat[i,i] + " ");
            
            }
            Console.WriteLine();
            // esta fazendo para mostrar os numeros negativos da matriz
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {count++;

                    }
                }
            }
            
            // resultado do numero negativo
            Console.WriteLine("Numero negativo: " + count);
        }
    }
}
