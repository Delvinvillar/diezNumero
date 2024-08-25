using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piezaDeHierro
{
   public class piezas
    {
       public void perfiles()
       { 
        int pieza = 0;
        int contador = 1;
         decimal piezatotal;
        decimal piezzamini =120;
        decimal  piezzamax = 130;
        double piezaaptas = 0;
        double piezanoaptas = 0;
         try
         {
                Console.WriteLine("ingrese el numero de pieza a evaluar");
                pieza = Convert.ToInt32(Console.ReadLine());

                while (contador <= pieza)
                {
                    Console.WriteLine($"Ingrese la piezza : #{contador} ");
                    piezatotal = Convert.ToDecimal  (Console.ReadLine());

                    if (piezatotal >= piezzamini && piezatotal <= piezzamax)
                    {
                        piezaaptas++;
                    }
                    else
                    {
                        piezanoaptas++;
                    }
                        contador++;
                }
                Console.WriteLine($"esta son la pieza que son aptas para fabricar perfiles: {piezaaptas}");

                Console.WriteLine($" esta son la pieza no aptas {piezanoaptas} ");
         }
          catch (Exception ex)
          { 
          Console.WriteLine(ex.Message);
          }
            

       }



    }
}
