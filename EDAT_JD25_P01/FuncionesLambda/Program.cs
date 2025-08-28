using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresion lambda como funcion");

        //Func<int, int> b = (a) => a * 2;

        //int resultado = b(4);


        //Console.WriteLine("El resultado es: " + resultado);

        //Func<int,int, int> suma = (a, b) => a + b;



        //int resultado = suma(4, 6);
        //Console.WriteLine("El resultado es: " + resultado);

        Func<int, int, int> mayor = (a, b) =>
        {
            if (a > b)
            {
                return a;
            }




        //Persona pers = new Persona();

        //int edad = 18;

        //edad++; 
        //edad++;

        //Console.WriteLine("El valor de la variable edad es: " + edad );
        //Console.WriteLine("La direccion de memoria es: " + );
    }
}