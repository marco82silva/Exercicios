using System;
class projeto{

    static void Main(){

        double qtde_litros,tempo,velocidade,km_litros,distancia;

        // Solicita e lê as informações da viagem
Console.Write("\tInforme o tempo em horas do percurso: ");
tempo = Double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("\tInforme a velocidade média em Km/h do veículo: ");
velocidade = Double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("\tInforme a quantidade de Kilometros que o veículo faz com 1 litro: ");
km_litros = Double.Parse(Console.ReadLine());
Console.WriteLine();
// Efetua o cálculo da distância percorrida e da quantidade de litros consumida na viagem
distancia = (velocidade * tempo);
qtde_litros = (distancia / km_litros);

// Exibe a distância percorrida da viagem
Console.WriteLine("\tA distância do percurso foi de: {0} Km",distancia);
Console.WriteLine();
// Exibe o resultado da quantidade de litros de combustível gasto na viagem
Console.WriteLine("\tA quantidade de combustível gasto na viagem foi de: {0} litros", qtde_litros);
Console.WriteLine();
        
    }
}