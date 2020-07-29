using System;
/*Calcular a média harmônica das notas de um aluno. Define como utilizar uma
console manipulando dados de entrada e saída e declarando variáveis*/
class projeto{

    static void Main(){
        double nota1,nota2,nota3,nota4,notah;

        Console.Write("Insira a 1ª nota do aluno: ");
        nota1=double.Parse(Console.ReadLine());
        Console.Write("Insira a 2ª nota do aluno: ");
        nota2=double.Parse(Console.ReadLine());
        Console.Write("Insira a 3ª nota do aluno: ");
        nota3=double.Parse(Console.ReadLine());
        Console.Write("Insira a 4ª nota do aluno: ");
        nota4=double.Parse(Console.ReadLine());

        notah=(4/((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4)));

        Console.Write("O valor da Média Harmonica é: {0}",notah);



    }
}