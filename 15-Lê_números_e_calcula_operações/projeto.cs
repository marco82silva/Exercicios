using System;
class projeto{

    static void Main(){
       double N1,N2,SUBT,MULT,ADIC,DIVI;

        Console.Write("Insira o 1º numero: ");
        N1=double.Parse(Console.ReadLine());
        Console.Write("Insira o 2º numero: ");
        N2=double.Parse(Console.ReadLine());
        
        SUBT=N1-N2;
        MULT=N1*N2;
        ADIC=N1+N2;
        DIVI=N1/N2;

        Console.Write("O valor da SUBTRAÇÃO de {0} - {1} é: {2}",N1,N2,SUBT);
        Console.WriteLine();
        Console.Write("O valor da MULTIPLICAÇÃO de {0} * {1} é: {2}",N1,N2,MULT);
        Console.WriteLine();
        Console.Write("O valor da SOMA de {0} + {1} é: {2}",N1,N2,ADIC);
        Console.WriteLine();
        Console.Write("O valor da DIVISÃO de {0} / {1} é: {2}",N1,N2,DIVI);
        Console.WriteLine();



    }
}