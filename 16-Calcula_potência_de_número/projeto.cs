using System;
class projeto{
    static void Main(){

        double N,EXP,POT;

        Console.Write("Informe o Numero: ");
        N=double.Parse(Console.ReadLine());
        Console.Write("Informe o Expoente: ");
        EXP=double.Parse(Console.ReadLine());

        POT=Math.Pow(N,EXP);

        Console.WriteLine("A Potencia do numero {0} com expoente {1} é: {2}",N,EXP,POT);

    }
}