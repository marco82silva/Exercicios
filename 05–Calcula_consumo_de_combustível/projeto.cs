using System;

/*Calcular o consumo de combustível por Km. Mostra de forma simples conceitos de
entrada e saída de dados e declaração de variáveis:*/

class projeto{

    static void Main(){
    
        double ki,kf,dp,cc,gc;

        Console.Write("Informe a Quilometragem Inicial: ");
        ki=double.Parse(Console.ReadLine());
        Console.Write("Informe a Quilometragem Final: ");
        kf=double.Parse(Console.ReadLine());
        dp=(kf-ki);
        Console.Write("Informe a quantidade de combustivel consumida: ");
        cc=double.Parse(Console.ReadLine());
        gc=(dp/cc);

        Console.Write("O consumo de combustivel para o trecho perchorrido foi:{0} KM",gc);
    }
}