using System;

/*Calcular o quadrado da diferença entre dois números quaisquer. Demonstra de
forma simples o uso de consoles, entrada e saída de dados e o método pow:*/
class projeto{

    static void Main(){
        double N1,N2,DIF;

        Console.Write("Informe um numero: ");
        N1=double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo Numero: ");
        N2=double.Parse(Console.ReadLine());

        DIF=Math.Pow(N1,2) - Math.Pow(N2,2);

        Console.WriteLine("O quadrado da Diferença entre os numero {0} e {1} é de: {2}", N1,N2,DIF);    
    }
}