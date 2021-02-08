using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace promedio_matriz

    
{
    class Program
    {

        

        static void Main(string[] args)
             {
            double sumatoria = 0.0;
            double promedio = 0.0;
            Random rnd = new Random();
            int n = 0, m = 0; 

            int[,] datos = new int[4,7];

            //llenamos los datos

            for (n=0; n<4; n++)
            {
                for(m=0; m < 7; m++)
                {
                    datos[n, m] = rnd.Next(20);
                }
            }
            
          //imprimir datos

            for(n=0; n<4;  n++)
            {
                Console.Write("semana {0} ",  n);
                
                  

                for(m=0;m<7;m++)
                {
                    Console.Write(" {0} ",  n);

                }
                Console.WriteLine();

            }
            
            //calculamos el promedio por semana

            for(n=0;n<4;n++)
            {
                sumatoria = 0.0;
               promedio = 0.0;
                    

                for(m=0;m<7; m++)
                {
                    sumatoria += datos[n, m];
                    
                    
                }

                promedio = sumatoria / 7.0;
                Console.Write("el promedio {0} es  {1} ", n, promedio);


                // calculamos promedio total x mes

                

                   
            }
            sumatoria = 0.0;
            promedio = 0.0;

            for (n = 0; n < 4; n++)
            {
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n , m];
                }


            }

            promedio = sumatoria / 28.0;

            Console.Write(" el promedio total  {0} ", promedio);
        }
    }
}
