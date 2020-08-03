using System;
/* Calcular a Média Ponderada de duas provas realizadas por um aluno. Mostra de
forma simples como declarar variáveis e manipular dados de entrada e saída */
class projeto{

    static void Main(){
        double N1,N2,P1,P2,MP;

        Console.Write("Informe a 1ª nota: ");
        N1 = double.Parse(Console.ReadLine());
        Console.Write("Informe a 2ª nota: ");
        N2 = double.Parse(Console.ReadLine());
        Console.Write("Informe o peso da 1ª prova: ");
        P1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o peso da 2ª prova: ");
        P2 = double.Parse(Console.ReadLine());

        MP = (N1*P1 + N2*P2)/(P1 + P2);

        Console.Write("O Valor da media ponderada do aluno é: {0}",MP);
        



    }
}