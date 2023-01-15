 using System.IO;
 using System.Linq;
 using System;
 using System.Text.RegularExpressions;
 
 

 
 class DIO{

  static void Main(string[] args){
    string f="";
    double horas = 0;
    double valorTotal = 0; 
    bool i =true;
    int numveiculos = 1;
    string[] lista = new string[numveiculos+1];
    string placa = "";
    Console.WriteLine("Digite um valor inicial para ser cobrado:");
    double valori = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para ser cobrado por hora:");
    double valorh = double.Parse(Console.ReadLine());
    Console.Clear();

   


    while(i){
      Console.WriteLine("1 - Cadastrar veiculo\n2 - Remover veiculo\n3 - Listar veiculos\n4 - Encerrar programa");
      int acao = int.Parse(Console.ReadLine());
      
      switch(acao){

        case 1:
          Console.WriteLine("Digite a placa do veiculo:");
          placa = string.Format(Console.ReadLine());
          lista[numveiculos] = placa;
          numveiculos++;
          Array.Resize(ref lista, numveiculos+1);
          Console.Clear();
        break;

        case 2:
          Console.WriteLine("Digite a placa do veiculo que deseja remover:");
          placa = string.Format(Console.ReadLine());

          for(int z = 0; z < lista.Length; z++){
            if(placa.Equals(lista[z])){
                  lista[z] ="";
                  
                            
            }
            }
          Console.WriteLine("Digite quantas horas o veiculo ficou estacionado");
          horas = int.Parse(Console.ReadLine());
          valorTotal = valori + (valorh * horas);
          Console.WriteLine("O valor cobrado foi de R$" + valorTotal);
          Console.WriteLine("Pressione qualquer tecla para continuar");
          Console.ReadLine();
          Console.Clear();
          

        break;

        case 3:
          foreach(string p in lista){
            if(f.Equals(p)){}
            else
            {
            Console.WriteLine(p);
            }
            
           } 
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        break;

        case 4:
          i = false;
        break;

      }
      
    }

  
   }
  }


