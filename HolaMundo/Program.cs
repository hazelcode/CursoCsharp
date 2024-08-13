class Program {
    static void Main() {
        // TEXTOS, CARÁCTERES
        // LEER TEXTOS Y CARÁCTERES
        // Anotación: Los textos se representan con comillas dobles ""
        // Anotación: Los carácteres se representan con comillas simples ''
        // string es para textos
        // char es para carácteres
        //string miTexto = "Calor";
        //char caracter = 'd';

        // SIGUIENTE TEMA
        // Leer textos y carácteres
        // Console.ReadLine(); // Para textos
        // char.Parse(Console.ReadLine()!); // Para carácteres

        Console.WriteLine("Dime algo");
        string miTexto = Console.ReadLine()!;
        Console.WriteLine("Mostrar ese algo: "+miTexto);

        // Para leer carácteres
        Console.WriteLine("Dime un carácter");
        char c = char.Parse(Console.ReadLine()!);
        Console.WriteLine("Mostrar ese carácter: "+c);

        // Ejemplo real
        Console.WriteLine("Dime tu nombre");
        string nombre = Console.ReadLine()!;
        Console.WriteLine($"Hola, {nombre}!");

        Console.WriteLine("Cuál es tu letra favorita?");
        char letra = char.Parse(Console.ReadLine()!);
        Console.WriteLine("Tu letra favorita es "+letra);
    }
}