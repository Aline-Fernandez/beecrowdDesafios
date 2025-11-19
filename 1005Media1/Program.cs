using System;
using System.Globalization;

public class Program {
    public static void Main(string[] args) {
        const double PESO_A = 3.5;
        const double PESO_B = 7.5;
        const double SOMA_PESOS = PESO_A + PESO_B; 

      
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = ((A * PESO_A) + (B * PESO_B)) / SOMA_PESOS;

        string resultadoFormatado = string.Format(
            CultureInfo.InvariantCulture,
            "MEDIA = {0:F5}",
            media
        );

        Console.WriteLine(resultadoFormatado);
    }
}