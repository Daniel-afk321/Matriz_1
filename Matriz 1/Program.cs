using System;

namespace Matriz_1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ordem da matriz:");
            // entra dos dados          

            int n = int.Parse(Console.ReadLine()); 
            
            int[,] mat = new int[n, n];
            Console.WriteLine("Digite os numeros que compoem a matriz separando-os por um espaço, Aperte enter cada vez que terminar uma linha para ir para a proxima :");
            // Loop das linhas da matriz
            for (int i = 0; i < n; i++) {

                // esta criando uma matriz de subcadeias
                string[] values = Console.ReadLine().Split(' '); 
                
                // Loop das colunas da matriz
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
            // esta mostrando os numeros negativos da matriz
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
