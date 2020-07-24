using System;
/* Utilizar a propriedade distributiva entre 4 números nos quais devem ser somados e 
multiplicados entre si. Simples utilização de entrada, saída e declaração de variáveis: */
class projeto{

    static void Main(){
        double N1,N2,N3,N4,
               S_N1N2,S_N1N3,S_N1N4,
               S_N2N3,S_N2N4,S_N3N4,
               M_N1N2,M_N1N3,M_N1N4,
               M_N2N3,M_N2N4,M_N3N4;;

            Console.Write("Informe o 1º número: ");
            N1 = Double.Parse(Console.ReadLine());
            Console.Write("Informe o 2º numero: ");
            N2 = Double.Parse(Console.ReadLine());
            Console.Write("Informe o 3º numero: ");
            N3 = Double.Parse(Console.ReadLine());
            Console.Write("Informe o 4º numero: ");
            N4 = Double.Parse(Console.ReadLine());

            S_N1N2 = N1+N2;
            S_N1N3 = N1+N3;
            S_N1N4 = N1+N4;
            S_N2N3 = N2+N3;
            S_N2N4 = N2+N4;
            S_N3N4 = N3+N4;

            M_N1N2 = N1*N2;
            M_N1N3 = N1*N3;
            M_N1N4 = N1*N4;
            M_N2N3 = N2*N3;
            M_N2N4 = N2*N4;
            M_N3N4 = N3*N4;

            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N1,N2,S_N1N2);
            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N1,N3,S_N1N3);
            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N1,N4,S_N1N4);
            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N2,N3,S_N2N3);
            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N2,N4,S_N2N4);
            Console.WriteLine("\t\t\tO valor da soma {0} + {1} = {2}",N3,N4,S_N3N4);
            Console.WriteLine("\t\t\t--------------------------------------");
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N1,N2,M_N1N2);
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N1,N3,M_N1N3);
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N1,N4,M_N1N4);
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N2,N3,M_N2N3);
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N2,N4,M_N2N4);
            Console.WriteLine("\t\t\tO valor da multiplicação {0} * {1} = {2}",N3,N4,M_N3N4);

    }
}
