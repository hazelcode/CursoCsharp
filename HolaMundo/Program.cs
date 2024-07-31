// Temas de éste capítulo:
//  - Impresión en pantalla VISTO
//  - Variables VISTO
//     - Enteros de 16, 32 y 64 bits
//     - Números double y float
//     - Constantes
//     - Variables sin signo
// - Leer entrada

class Program {
    static void Main() {
        // SÓLO REPRESENTAN NÚMEROS ENTEROS
        // NO DECIMALES
        // short 16 bits
        // int 32 bits
        // long 64 bits

        // DECIMALES
        // double y float
        // float solo puede representar hasta 7 decimales, termina con una F
        // double solo puede representar hasta 15 decimales
        // decimal solo puede representar hasta 28 decimales, termina con una M
        decimal x = 3.14164848484346326377375776785685385835m;
        Console.WriteLine(x);
        ulong edad = 0;

        // CONSTANTES const
        const double pi = 3.1416;

        // VARIABLES SIN SIGNO
        int a = -7;
        uint b = 1;

        // LEER ENTRADA
        double estatura;
        Console.WriteLine("Cuál es tu estatura en metros?");
        estatura = double.Parse(Console.ReadLine());
        Console.WriteLine("Tu estatura es de " + estatura + " metros");
    }
}