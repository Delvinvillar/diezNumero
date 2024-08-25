

namespace diezNumero
{
    public class secdiez
    {
        public void dieznumeroo()
        {
            int numero = 0;
            decimal num = 0;
            int contador = 1;

            decimal suma = 0;
            decimal promedio = 0;
            try
            {
                Console.WriteLine("cuanto numero quiere ingresar");
                numero = Convert.ToInt32(Console.ReadLine());

                while (numero >= contador)
                {
                    Console.WriteLine($"ingrese el numero: #{contador}");
                    num = Convert.ToDecimal(Console.ReadLine());


                    if (numero >= 10)
                    {
                        suma += num;
                    }
                    contador++;
                }
                promedio = num % suma;

                if (numero >= 10)
                {
                    Console.WriteLine($"esta es la suma de los numero ingresados: {suma}");
                    Console.WriteLine($"este es el promedio: {promedio}");

                }
                else
                {
                    Console.WriteLine("para poder realizar la suma tiene que ingresar mas de 10 numero");

                    Console.WriteLine(" Bay Bay");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"hay un error{ex.Message}");
            }
        }

    }
}
