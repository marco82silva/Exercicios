using System;
/*Calcular o custo com a criação de coelhos. Mostra de forma simples como
manipular dados via console e declarar variáveis, e expressões algébricas:*/
class projeto{

    static void Main(){
        int nr_coelhos;
        double custo;

       Console.Write("Insira o numero de coelhos na criação: ");
       nr_coelhos = Int32.Parse(Console.ReadLine());

        custo = (nr_coelhos * 0.70)/28;

        Console.WriteLine("O Custo total com a criação de {0} coelhos da criação é: R$ {1}",nr_coelhos,custo);
    }
}

