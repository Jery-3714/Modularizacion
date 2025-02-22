using System;

class Program
{
    
    static void Calculadora()
    {
        double num1, num2;
        string operacion;

        Console.Write("Ingresa el primer número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
            Console.Write("Por favor, ingresa un número válido: ");

        Console.Write("Ingresa el segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
            Console.Write("Por favor, ingresa un número válido: ");

        Console.WriteLine("Selecciona la operación: (+, -, *, /)");
        operacion = Console.ReadLine();

        switch (operacion)
        {
            case "+":
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                    Console.WriteLine($"Resultado: {num1 / num2}");
                else
                    Console.WriteLine("Error: División por cero.");
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    static void ValidacionContraseña()
    {
        string contraseña;
        do
        {
            Console.Write("Ingresa la contraseña: ");
            contraseña = Console.ReadLine();
            if (contraseña != "1234")
                Console.WriteLine("Contraseña incorrecta, intenta nuevamente.");
        } while (contraseña != "1234");

        Console.WriteLine("Acceso concedido.");
    }
    static void VerificarPrimo()
    {
        int numero;
        Console.Write("Ingresa un número para verificar si es primo: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
            Console.Write("Por favor, ingresa un número válido: ");

        bool esPrimo = true;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo && numero > 1)
            Console.WriteLine($"{numero} es un número primo.");
        else
            Console.WriteLine($"{numero} no es un número primo.");
    }
    static void SumarNumerosPares()
    {
        int numero, suma = 0;

        Console.WriteLine("Ingresa números para sumar, ingresa 0 para finalizar.");
        do
        {
            while (!int.TryParse(Console.ReadLine(), out numero))
                Console.Write("Por favor, ingresa un número válido: ");

            if (numero % 2 == 0 && numero != 0)
                suma += numero;

        } while (numero != 0);

        Console.WriteLine($"La suma de los números pares ingresados es: {suma}");
    }
    static void ConversionTemperatura()
    {
        double temperatura;

        Console.WriteLine("Selecciona una opción de conversión:");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa la temperatura: ");
        while (!double.TryParse(Console.ReadLine(), out temperatura))
            Console.Write("Por favor, ingresa una temperatura válida: ");

        if (opcion == 1)
            Console.WriteLine($"Temperatura en Fahrenheit: {temperatura * 9 / 5 + 32}");
        else if (opcion == 2)
            Console.WriteLine($"Temperatura en Celsius: {(temperatura - 32) * 5 / 9}");
        else
            Console.WriteLine("Opción no válida.");
    }
    static void ContarVocales()
    {
        Console.Write("Ingresa una frase: ");
        string texto = Console.ReadLine().ToLower();
        int contadorVocales = 0;

        foreach (char c in texto)
        {
            if ("aeiou".Contains(c))
                contadorVocales++;
        }

        Console.WriteLine($"La frase contiene {contadorVocales} vocales.");
    }
    static void CalcularFactorial()
    {
        int numero;
        Console.Write("Ingresa un número para calcular su factorial: ");
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            Console.Write("Por favor, ingresa un número válido y no negativo: ");

        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
    static void JuegoAdivinanza()
    {
        Random rand = new Random();
        int numeroAleatorio = rand.Next(1, 101);
        int intento;
        do
        {
            Console.Write("Adivina el número entre 1 y 100: ");
            while (!int.TryParse(Console.ReadLine(), out intento))
                Console.Write("Por favor, ingresa un número válido: ");

            if (intento < numeroAleatorio)
                Console.WriteLine("Demasiado bajo.");
            else if (intento > numeroAleatorio)
                Console.WriteLine("Demasiado alto.");
            else
                Console.WriteLine("¡Felicidades! Adivinaste el número.");
        } while (intento != numeroAleatorio);
    }
    static void IntercambiarNumeros(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void PasoPorReferencia()
    {
        int num1, num2;
        Console.Write("Ingresa el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
            Console.Write("Por favor, ingresa un número válido: ");

        Console.Write("Ingresa el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
            Console.Write("Por favor, ingresa un número válido: ");

        Console.WriteLine($"Antes de intercambiar: num1 = {num1}, num2 = {num2}");

        IntercambiarNumeros(ref num1, ref num2);

        Console.WriteLine($"Después de intercambiar: num1 = {num1}, num2 = {num2}");
    }
    static void TablaMultiplicar()
    {
        int numero;
        Console.Write("Ingresa un número para ver su tabla de multiplicar: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
            Console.Write("Por favor, ingresa un número válido: ");

        Console.WriteLine($"Tabla de multiplicar de {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calculadora básica");
            Console.WriteLine("2. Validación de contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversión de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("11. Salir");

            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: Calculadora(); break;
                case 2: ValidacionContraseña(); break;
                case 3: VerificarPrimo(); break;
                case 4: SumarNumerosPares(); break;
                case 5: ConversionTemperatura(); break;
                case 6: ContarVocales(); break;
                case 7: CalcularFactorial(); break;
                case 8: JuegoAdivinanza(); break;
                case 9: PasoPorReferencia(); break;
                case 10: TablaMultiplicar(); break;
                case 11: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 11);
    }
}
