using System;
class projeto{

    static void Main(){
      double area,lado;

      Console.Write("Informe o lado do quadrado: ");
      lado=double.Parse(Console.ReadLine());

      area=lado*lado;

      Console.Write("A area do quadrado é: {0}",area);
    }
}