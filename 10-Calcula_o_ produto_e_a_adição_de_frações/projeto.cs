using System;
/* Calcular o produto e a adição de duas frações. Mostra de forma simples como utilizar variáveis e manipular dados via console*/
class projeto{

    static void Main(){
        double NUM1,NUM2,DEN1,DEN2,FRAC1,FRAC2,SOMA,PRODUTO;

        Console.Write("Informe o 1º numerador da fração: ");
        NUM1=double.Parse(Console.ReadLine());
        Console.Write("Informe o 2º numerador da fração: ");
        NUM2=double.Parse(Console.ReadLine());
        Console.Write("Informe o 1º denominador da fração: ");
        DEN1=double.Parse(Console.ReadLine());
        Console.Write("Informe o 2º denominador da fração: ");
        DEN2=double.Parse(Console.ReadLine());

        FRAC1=(NUM1/DEN1);
        FRAC2=(NUM2/DEN2);
        SOMA=FRAC1+FRAC2;
        PRODUTO=FRAC1*FRAC2;

        Console.WriteLine("A soma das frações {0} e {1} foi de: {2}",FRAC1,FRAC2,SOMA);
        Console.WriteLine("A multiplicação das frações {0} e {1} foi de: {2}",FRAC1,FRAC2,PRODUTO);
        
    }
}