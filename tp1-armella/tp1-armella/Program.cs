using System;
using System.Globalization;

namespace tp1_armella
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1:");
            Ejercicio1();
            Console.WriteLine("\n------\nEjercicio 2:\n");
            Ejercicio2();
            Console.WriteLine("\n------\nEjercicio 3:\n");
            Ejercicio3();
            Console.WriteLine("\n------\nEjercicio 4:\n");
            Ejercicio4();
            Ejercicio4Calculadora();
        }

        static void Ejercicio1()
        {
            int resto, numInvertido = 0;
            Console.Write("Ingrese un numero para invertirlo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num > 0) {
                while(num != 0)
                {
                    resto = num % 10;
                    num = num / 10;
                    numInvertido = numInvertido * 10 + resto;
                }
                Console.WriteLine("El numero invertido es: " + numInvertido);
            }
            else
            {
                Console.WriteLine("El numero {0} no es positivo.", num);
            }
        }

        static void Ejercicio2()
        {
            int opcion, num1, num2, resultado = 0, errorDivision = 0, auxiliar = 4;

            
            Console.WriteLine("1 : Sumar\n2 : Restar\n3 : Multiplicar\n4 : Dividir\n0 : Salir");
            Console.Write(">> ");
            opcion = Convert.ToInt32(Console.ReadLine());

            while(opcion < 0 || opcion > 4)
            {
                Console.WriteLine("La operación elegida no existe, intente de nuevo: ");
                Console.WriteLine("1 : Sumar\n2 : Restar\n3 : Multiplicar\n4 : Dividir\n0 : Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            
            while(opcion != 0) 
            {

                Console.WriteLine("Ingrese los 2 numeros: ");
                Console.Write("1º >> ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2º >> ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        auxiliar = 0;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        auxiliar = 1;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        auxiliar = 2;
                        break;
                    case 4:
                        if(num2 != 0){
                            resultado = num1 / num2;
                        }
                        else
                        {
                            errorDivision = 1;
                        }
                        auxiliar = 3;
                        break;
                    default:
                        Console.WriteLine("Error: esa opción no existe...");
                        break;
                }
                if(errorDivision == 0) 
                {
                    switch (auxiliar) {  // Ejercicio 4, punto 5

                        case 0:
                            Console.WriteLine("La suma de {0} y {1} es: {2}",num1,num2, resultado);
                            break;
                        case 1:
                            Console.WriteLine("La resta de {0} y {1} es: {2}", num1, num2, resultado);
                            break;
                        case 2:
                            Console.WriteLine("La multiplicacion de {0} y {1} es: {2}", num1, num2, resultado);
                            break;
                        case 3:
                            Console.WriteLine("La division de {0} y {1} es: {2}", num1, num2, resultado);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: el segundo número no puede ser 0");
                }
                Console.WriteLine("---");
                Console.WriteLine("1 : Sumar\n2 : Restar\n3 : Multiplicar\n4 : Dividir\n0 : Salir");
                Console.Write(">> ");
                opcion = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Terminando...");
            
        }

        static void Ejercicio3()
        {
            float num, num1, num2;
            Console.WriteLine("Ingrese un numero (si es decimal usar ','): ");
            Console.Write(">> ");
            num = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("Al cuadrado: " + Math.Pow(num, 2));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Seno (tomando el numero en radianes): " + Math.Sin(num));
            Console.WriteLine("Coseno (tomando el numero en radianes): " + Math.Cos(num));
            Console.WriteLine("Parte entera: " + Math.Truncate(num));

            Console.WriteLine("---\nIngrese dos numeros para saber el mayor: ");
            Console.Write("1º >> ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("2º >> ");
            num2 = Convert.ToSingle(Console.ReadLine());
            if(num1 != num2)
            {
                Console.WriteLine("... El maximo es: {0} y el minimo es: {1}", Math.Max(num1, num2), Math.Min(num1, num2));
            }
            else
            {
                Console.WriteLine("Los numeros son iguales.");
            }
                

        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese un texto: ");
            string cadena = Console.ReadLine();
            ObtenerAlgunasLetras(cadena);
            Console.WriteLine("\n-> El texto tiene {0} caracteres.", cadena.Length);
            cadena = UnirDosCadenas(cadena);
            RecorrerString(cadena);
            BuscarOcurrenciaDePalabra(cadena);
            Console.WriteLine("-> Texto en mayusculas: " + cadena.ToUpper());
            Console.WriteLine("-> Texto en minusculas: " + cadena.ToLower());
            CompararDosCadenas(cadena);
        }

        static void ObtenerAlgunasLetras(string cadena)
        {
            int numAleatorio, i = 0;
            char[] chars = cadena.ToCharArray();

            Console.Write("-> Algunas letras del texto: ");
            foreach (var letras in chars)
            {
                numAleatorio = new Random().Next(0, 2);

                if (letras != ' ' && numAleatorio == 1)
                {
                    Console.Write(" " + letras);
                }
                i++;
            }
        }

        static string UnirDosCadenas(string cadena)
        {
            string cadena2, cadenaFinal;
            Console.Write("\nIngrese otro texto para unir con el anterior: ");
            cadena2 = " " + Console.ReadLine();
            cadenaFinal = String.Concat(cadena,cadena2);
            Console.WriteLine("-> Nuevo texto: " + cadenaFinal);
            return cadenaFinal;
        }

        static void RecorrerString(string cadena)
        {
            int cont=0;
            Console.WriteLine("-> Caracteres del texto: ");
            foreach (var palabras in cadena)
            {
                Console.Write(palabras);
                if(cont < cadena.Length-1)
                {
                    Console.Write("; ");
                }
                cont++;
            }
        }

        static void BuscarOcurrenciaDePalabra(string cadena)
        {
            int contadorDePalabrasIguales = 0;
            string[] cadenaSeparada = cadena.Split(' ');
            Console.Write("\nIngrese una palabra para buscar su ocurrencia en el texto: ");
            string palabraABuscar = Console.ReadLine();
            foreach (var palabras in cadenaSeparada)
            {
                if (String.Compare(palabraABuscar,palabras) == 0)
                {
                    contadorDePalabrasIguales++;
                }
            }
            Console.WriteLine("-> La palabra \"{0}\" aparece {1} veces en el texto.",palabraABuscar,contadorDePalabrasIguales);
        }

        static void CompararDosCadenas(string cadena)
        {
            Console.WriteLine("Ingrese un texto para comparar con el anterior: ");
            string nuevaCadena = Console.ReadLine();
            bool comparacion = String.Equals(cadena, nuevaCadena,StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"-> El primer texto es < {(comparacion ? "igual" : "distinto")} > al nuevo.");
        }

        static void Ejercicio4Calculadora()
        {
            int signo = 4,num1,num2,resultado = 0;
            Console.Write("Ingrese el calculo a realizar (por ejemplo '10+5'): ");
            string calculo = Console.ReadLine();
            string[] numeros = calculo.Split('+','-','*','/');
            num1 = Convert.ToInt32(numeros[0]);
            num2 = Convert.ToInt32(numeros[1]);

            foreach (var caracteres in calculo)
            {
                switch (caracteres)
                {
                    case '+':
                        signo = 0;
                        break;
                    case '-':
                        signo = 1;
                        break;
                    case '*':
                        signo = 2;
                        break;
                    case '/':
                        signo = 3;
                        break;
                    default:
                        break;
                }
            }
            switch (signo)
            {
                case 0:
                    resultado = num1 + num2;
                    break;
                case 1:
                    resultado = num1 - num2;
                    break;
                case 2:
                    resultado = num1 * num2;
                    break;
                case 3:
                    if(num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: no existe la división por 0");
                    }
                    break;
                case 4:
                    Console.WriteLine("Error: operacion ingresada incorrecta");
                    break;
            }
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
