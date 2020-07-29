using System;
/*Calcular o salário total de um vendedor. Define pontos importantes de como se utilizar console de entrada e saída de dados*/
class projeto{

    static void Main(){
        int cod_funcionario;
        double salario_fixo, total_vendas, percentual_ganho, salario_total;

        Console.Write("Informe o código do Funcionario: ");
        cod_funcionario = Int32.Parse (Console.ReadLine());
        Console.Write("Informe o salario fixo do funcionario: ");
        salario_fixo = double.Parse (Console.ReadLine());
        Console.Write("Informe o valor total de vendas do funcionario: ");
        total_vendas = double.Parse (Console.ReadLine());
        Console.Write("Informe o valor do percentual ganho sobre o total das vendas: ");
        percentual_ganho = double.Parse(Console.ReadLine());

        salario_total= (salario_fixo+(total_vendas*(percentual_ganho/100)));

        Console.Write("O funcionario de Codigo nº {0} tem salario total de: {1}",cod_funcionario,salario_total);
 

    }
}