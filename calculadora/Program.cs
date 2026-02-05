using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos las variables 
            // Usamos 'double' en lugar de 'int' para poder usar decimales (ej: 5.5)
            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            string operacion = "";

            Console.WriteLine("=== MI PRIMERA CALCULADORA ===");

            // Pedimos los números al usuario
            Console.Write("Escribe el primer número: ");
            // OJO: ReadLine lee texto. Convert.ToDouble lo transforma a número.
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            // 3. Menú de opciones
            Console.WriteLine("\nElige una operación:");
            Console.WriteLine("+ : Suma");
            Console.WriteLine("- : Resta");
            Console.WriteLine("* : Multiplicación");
            Console.WriteLine("/ : División");
            Console.Write("Tu elección: ");

            operacion = Console.ReadLine();

            // 4. Lógica de la calculadora (Decisiones)
            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;

                case "/":
                    // Validación especial: No se puede dividir entre cero
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("El resultado de la división es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("¡Error! No se puede dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            // 5. Esperar antes de cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}